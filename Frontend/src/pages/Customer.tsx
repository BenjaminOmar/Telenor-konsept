import {Button} from '@rneui/base';
import React, {useState} from 'react';
import {
  View,
  StyleSheet,
  Modal,
  Text,
  TouchableOpacity,
  TouchableWithoutFeedback,
} from 'react-native';
import CustomerList from '../components/customer/CustomerList';
import CustomInput from '../components/common/inputs/CustomInput';
import SearchInput from '../components/common/inputs/SearchInput';

function Customer() {
  const [modalVisible, setModalVisible] = useState(false);
  const [customerName, setCustomerName] = useState('');

  const handleAddButtonPress = () => {
    setModalVisible(true);
  };

  const handleCloseModal = () => {
    setModalVisible(false);
  };

  return (
    <View style={styles.container}>
      <View style={styles.customerHeader}>
        <View style={styles.searchInput}>
          <SearchInput
            value={customerName}
            setValue={setCustomerName}
            placeholder="Søk etter bedrift"
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
      <CustomerList search={customerName} />
      <Modal
        animationType="fade"
        transparent={true}
        visible={modalVisible}
        onRequestClose={handleCloseModal}>
        <TouchableWithoutFeedback onPress={handleCloseModal}>
          <View style={styles.modalOverlay}>
            <TouchableWithoutFeedback onPress={() => {}}>
              <View style={styles.modalContent}>
                <Text style={styles.headerText}>Ny bedrift</Text>
              </View>
            </TouchableWithoutFeedback>
          </View>
        </TouchableWithoutFeedback>
      </Modal>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
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
  modalOverlay: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'rgba(0,0,0,0.5)',
  },
  headerText: {
    fontSize: 24,
    fontWeight: 'bold',
    color: '#00ACE7',
    marginBottom: 20,
    marginTop: 10,
  },
  modalContent: {
    width: '80%',
    height: '70%',
    padding: 20,
    backgroundColor: 'white',
    borderRadius: 10,
    alignItems: 'center',
  },
});

export default Customer;
