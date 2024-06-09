import React, {useEffect, useState} from 'react';
import {
  View,
  Text,
  StyleSheet,
  FlatList,
  ActivityIndicator,
  RefreshControl,
  TouchableOpacity,
} from 'react-native';
import axios from 'axios';
import {useNavigation} from '@react-navigation/native';
import {NativeStackNavigationProp} from '@react-navigation/native-stack';
import {StackParamList} from '../../routing/StackNavigatiorConfig';
import {CustomerInterface} from '../../models/customer/CustomerInterface';

interface CustomerListProps {
  search: string;
  refreshKey: number;
}

type CustomerListNavigationProp = NativeStackNavigationProp<
  StackParamList,
  'CustomerDetails'
>;

const CustomerList: React.FC<CustomerListProps> = ({search, refreshKey}) => {
  const [data, setData] = useState<CustomerInterface[]>([]);
  const [loading, setLoading] = useState(true);
  const [refreshing, setRefreshing] = useState(false);
  const navigation = useNavigation<CustomerListNavigationProp>();

  useEffect(() => {
    fetchData();
  }, [refreshKey]);

  const fetchData = async () => {
    try {
      const response = await axios.get('http://localhost:3000/api/customer');
      setData(response.data.value);
      setLoading(false);
      setRefreshing(false);
    } catch (error) {
      console.error(error);
      setLoading(false);
      setRefreshing(false);
    }
  };

  const handleRefresh = () => {
    setRefreshing(true);
    fetchData();
  };

  const renderItem = ({item}: {item: CustomerInterface}) => (
    <TouchableOpacity
      style={styles.itemContainer}
      onPress={() => navigation.navigate('CustomerDetails', {customer: item})}>
      <Text style={styles.itemText}>{item.name}</Text>
    </TouchableOpacity>
  );

  if (loading) {
    return (
      <View style={styles.loaderContainer}>
        <ActivityIndicator size="large" color="#0000ff" />
      </View>
    );
  }

  const filteredData = data.filter(item =>
    item.name.toLowerCase().includes(search.toLowerCase()),
  );

  return (
    <FlatList
      data={filteredData}
      keyExtractor={item => item.customerId.toString()}
      renderItem={renderItem}
      contentContainerStyle={styles.listContainer}
      refreshControl={
        <RefreshControl refreshing={refreshing} onRefresh={handleRefresh} />
      }
    />
  );
};

const styles = StyleSheet.create({
  mainContainer: {
    flex: 1,
    backgroundColor: '#f0f0f0',
    padding: 10,
  },
  loaderContainer: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  listContainer: {
    padding: 10,
  },
  itemContainer: {
    padding: 20,
    marginVertical: 5,
    backgroundColor: '#ffffff',
    borderRadius: 12,
    shadowColor: '#000',
    shadowOffset: {width: 0, height: 2},
    shadowOpacity: 0.1,
    shadowRadius: 5,
    elevation: 3,
  },
  itemText: {
    fontSize: 16,
    color: '#333',
  },
  buttonContainer: {
    alignItems: 'flex-end',
    marginBottom: 10,
  },
});

export default CustomerList;
