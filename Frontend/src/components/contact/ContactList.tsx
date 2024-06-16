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
import {ContactInterface} from '../../models/contact/ContactInterface';
import ViewContactModal from './ViewContactModal'; // import the new modal component

interface ContactListProps {
  customerId: string;
  search: string;
  refreshKey: number;
}

const ContactList: React.FC<ContactListProps> = ({
  customerId,
  search,
  refreshKey,
}) => {
  const [data, setData] = useState<ContactInterface[]>([]);
  const [loading, setLoading] = useState(true);
  const [refreshing, setRefreshing] = useState(false);
  const [modalVisible, setModalVisible] = useState(false);
  const [selectedContact, setSelectedContact] =
    useState<ContactInterface | null>(null);

  useEffect(() => {
    fetchData();
  }, [refreshKey]);

  const fetchData = async () => {
    try {
      const response = await axios.get(
        'http://localhost:3000/api/contact/' + customerId,
      );
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

  const handleContactPress = (contact: ContactInterface) => {
    setSelectedContact(contact);
    setModalVisible(true);
  };

  const renderItem = ({item}: {item: ContactInterface}) => (
    <TouchableOpacity
      style={styles.itemContainer}
      onPress={() => handleContactPress(item)}>
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
    <View style={styles.mainContainer}>
      <FlatList
        data={filteredData}
        keyExtractor={item => item.contactId.toString()}
        renderItem={renderItem}
        contentContainerStyle={styles.listContainer}
        refreshControl={
          <RefreshControl refreshing={refreshing} onRefresh={handleRefresh} />
        }
      />
      <ViewContactModal
        contact={selectedContact}
        modalVisible={modalVisible}
        handleCloseModal={() => setModalVisible(false)}
      />
    </View>
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

export default ContactList;
