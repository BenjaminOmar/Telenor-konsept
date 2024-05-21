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

function Customer() {
  const [modalVisible, setModalVisible] = useState(false);

  const handleAddButtonPress = () => {
    setModalVisible(true);
  };

  const handleCloseModal = () => {
    setModalVisible(false);
  };

  return (
    <View style={styles.container}>
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
      <CustomerList />
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
    alignItems: 'flex-end',
    marginRight: 20,
    marginBottom: 5,
  },
  addButton: {
    backgroundColor: '#32CD32',
    borderRadius: 7,
    width: 70,
    height: 40,
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
