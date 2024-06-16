import {View, Text, StyleSheet} from 'react-native';
import React, {useState} from 'react';
import SearchInput from '../../../../../../components/common/inputs/SearchInput';
import NewCustomerModal from '../../../../../../components/customer/NewCustomerModal';
import CustomerList from '../../../../../../components/customer/CustomerList';
import {Button} from '@rneui/base';
import ContactList from '../../../../../../components/contact/ContactList';
import {RouteProp} from '@react-navigation/native';
import {StackParamList} from '../../../../../../routing/StackNavigatiorConfig';
import NewContactModal from '../../../../../../components/contact/NewContactModal';

type Props = {
  route: RouteProp<StackParamList, 'CustomerDetails'>;
};

const Contacts: React.FC<Props> = ({route}) => {
  const {customer} = route.params;
  const [modalVisible, setModalVisible] = useState(false);
  const [contactName, setContactName] = useState('');
  const [refreshKey, setRefreshKey] = useState(0);

  const handleAddButtonPress = async () => {
    setModalVisible(true);
  };

  const handleCloseModal = () => {
    setModalVisible(false);
  };

  const handleContactAdded = () => {
    setRefreshKey((prevKey: number) => prevKey + 1);
  };

  return (
    <View style={styles.container}>
      <View style={styles.customerHeader}>
        <View style={styles.searchInput}>
          <SearchInput
            value={contactName}
            setValue={setContactName}
            placeholder="Søk etter kontakt"
          />
        </View>
        <View style={styles.buttonContainer}>
          <Button
            icon={{
              name: 'add',
              type: 'material',
              size: 25,
              color: 'white',
            }}
            buttonStyle={styles.addButton}
            onPress={handleAddButtonPress}
          />
        </View>
      </View>
      <ContactList
        customerId={customer.customerId.toString()}
        search={contactName}
        refreshKey={refreshKey}
      />
      <NewContactModal
        customerId={customer.customerId.toString()}
        modalVisible={modalVisible}
        handleCloseModal={handleCloseModal}
        onCustomerAdded={handleContactAdded}
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    marginTop: 15,
  },
  buttonContainer: {
    marginRight: 20,
    marginBottom: 5,
  },
  customerHeader: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
    paddingHorizontal: 0,
    marginBottom: 10,
  },
  searchInput: {
    flex: 1,
  },
  addButton: {
    backgroundColor: '#32CD32',
    borderRadius: 10,
    width: 80,
    height: 47,
  },
});

export default Contacts;
