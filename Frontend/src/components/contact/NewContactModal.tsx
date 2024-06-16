import React, {useState} from 'react';
import {
  View,
  StyleSheet,
  Modal,
  Text,
  TouchableWithoutFeedback,
  Switch,
  ScrollView,
} from 'react-native';
import SearchInput from '../common/inputs/SearchInput';
import {Button} from '@rneui/base';
import axios from 'axios';

interface Props {
  customerId: string;
  modalVisible: boolean;
  handleCloseModal: () => void;
  onCustomerAdded: () => void;
}

const NewContactModal: React.FC<Props> = ({
  customerId,
  modalVisible,
  handleCloseModal,
  onCustomerAdded,
}) => {
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [position, setPosition] = useState('');

  const capitalizeFirstLetter = (str: string) => {
    return str.charAt(0).toUpperCase() + str.slice(1);
  };

  const resetForm = () => {
    setName('');
    setEmail('');
    setPhoneNumber('');
    setPosition('');
  };

  const handleCreateContact = async () => {
    const customerData = {
      name: capitalizeFirstLetter(name.trim()),
      email,
      phoneNumber,
      position,
      customerId,
    };

    try {
      const response = await axios.post(
        'http://localhost:3000/api/contact',
        customerData,
        {
          headers: {
            'Content-Type': 'application/json',
          },
        },
      );

      resetForm();
      handleCloseModal();
      onCustomerAdded();
    } catch (error) {
      console.error('Feilet med å lage kontakten:', error);
    }
  };

  const handleCancel = () => {
    resetForm();
    handleCloseModal();
  };

  return (
    <Modal
      animationType="fade"
      transparent={true}
      visible={modalVisible}
      onRequestClose={handleCloseModal}>
      <TouchableWithoutFeedback onPress={handleCloseModal}>
        <View style={styles.modalOverlay}>
          <TouchableWithoutFeedback onPress={() => {}}>
            <View style={styles.modalContent}>
              <Text style={styles.headerText}>Opprett kontakt</Text>
              <View style={styles.divider} />
              <ScrollView
                style={styles.scrollContainer}
                contentContainerStyle={styles.scrollContentContainer}
                persistentScrollbar={true}>
                <View style={styles.formContainer}>
                  <View style={styles.formFieldItem}>
                    <SearchInput
                      value={name}
                      setValue={setName}
                      placeholder="Navn"
                    />
                  </View>
                  <View style={styles.formFieldItem}>
                    <SearchInput
                      value={phoneNumber}
                      setValue={setPhoneNumber}
                      placeholder="Telefonnummer"
                    />
                  </View>
                  <View style={styles.formFieldItem}>
                    <SearchInput
                      value={email}
                      setValue={setEmail}
                      placeholder="Epost"
                    />
                  </View>
                  <View style={styles.formFieldItem}>
                    <SearchInput
                      value={position}
                      setValue={setPosition}
                      placeholder="Posisjon"
                    />
                  </View>
                </View>
              </ScrollView>
              <View style={styles.buttonContainer}>
                <Button
                  title="Avbryt"
                  buttonStyle={styles.cancelButton}
                  containerStyle={styles.button}
                  onPress={handleCancel}
                />
                <Button
                  title="Opprett"
                  buttonStyle={styles.createButton}
                  containerStyle={styles.button}
                  onPress={handleCreateContact}
                />
              </View>
            </View>
          </TouchableWithoutFeedback>
        </View>
      </TouchableWithoutFeedback>
    </Modal>
  );
};

const styles = StyleSheet.create({
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
    marginBottom: 10,
    marginTop: 10,
  },
  modalContent: {
    width: '80%',
    height: '52%',
    padding: 20,
    backgroundColor: 'white',
    borderRadius: 10,
    alignItems: 'center',
  },
  divider: {
    width: '100%',
    height: 3,
    borderRadius: 10,
    backgroundColor: '#CED0CE',
    marginVertical: 5,
    marginBottom: 20,
  },
  scrollContainer: {
    flex: 1,
    width: '100%',
  },
  scrollContentContainer: {
    alignItems: 'center',
  },
  formContainer: {
    width: '100%',
    alignItems: 'center',
  },
  formFieldItem: {
    marginBottom: 15,
  },
  buttonContainer: {
    flexDirection: 'row',
    alignSelf: 'flex-end',
    width: '70%',
    justifyContent: 'space-between',
  },
  button: {
    marginHorizontal: 5,
  },
  createButton: {
    backgroundColor: '#00ACE7',
    borderRadius: 10,
    width: 90,
    height: 47,
  },
  cancelButton: {
    backgroundColor: '#FF0000',
    borderRadius: 10,
    width: 90,
    height: 47,
  },
});

export default NewContactModal;
