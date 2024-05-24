import React, {useEffect, useState} from 'react';
import {
  View,
  Text,
  StyleSheet,
  FlatList,
  ActivityIndicator,
  RefreshControl,
} from 'react-native';
import axios from 'axios';

interface Customer {
  customerId: number;
  name: string;
}

interface CustomerListProps {
  search: string;
}

const CustomerList: React.FC<CustomerListProps> = ({search}) => {
  const [data, setData] = useState<Customer[]>([]);
  const [loading, setLoading] = useState(true);
  const [refreshing, setRefreshing] = useState(false);

  useEffect(() => {
    fetchData();
  }, []);

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

  const renderItem = ({item}: {item: Customer}) => (
    <View style={styles.itemContainer}>
      <Text style={styles.itemText}>{item.name}</Text>
    </View>
  );

  if (loading) {
    return (
      <View style={styles.loaderContainer}>
        <ActivityIndicator size="large" color="#0000ff" />
      </View>
    );
  }

  // Filter data based on the filterValue prop
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
    borderRadius: 8,
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
