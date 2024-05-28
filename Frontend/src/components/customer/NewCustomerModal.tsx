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
  modalVisible: boolean;
  handleCloseModal: () => void;
}

const NewCustomerModal: React.FC<Props> = ({
  modalVisible,
  handleCloseModal,
}) => {
  const [name, setName] = useState('');
  const [organizationNr, setOrganizationNr] = useState('');
  const [address, setAddress] = useState('');
  const [postCode, setPostCode] = useState('');
  const [county, setCounty] = useState('');
  const [email, setEmail] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [isBusiness, setIsBusiness] = useState(true);

  const handleCreateCustomer = async () => {
    const customerData = {
      name,
      isPrivateCustomer: !isBusiness, // send the opposite of isBusiness
      organizationNr: isBusiness ? organizationNr : undefined,
      address,
      postCode,
      county,
      email,
      phoneNumber,
    };

    try {
      const response = await axios.post(
        'http://localhost:3000/api/customer',
        customerData,
        {
          headers: {
            'Content-Type': 'application/json',
          },
        },
      );

      const data = response.data;
      console.log('Kunde er laget:', data);
      handleCloseModal();
    } catch (error) {
      console.error('Feilet med å lage kunde::', error);
    }
  };

  const handleCancel = () => {
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
              <Text style={styles.headerText}>Opprett Kunde</Text>
              <View style={styles.divider} />
              <ScrollView
                style={styles.scrollContainer}
                contentContainerStyle={styles.scrollContentContainer}
                persistentScrollbar={true}>
                <View style={styles.formContainer}>
                  <View style={styles.switchContainer}>
                    <Text style={styles.switchLabel}>
                      {isBusiness ? 'Bedrift' : 'Privatkunde'}
                    </Text>
                    <Switch
                      value={isBusiness}
                      onValueChange={value => setIsBusiness(value)}
                    />
                  </View>
                  <View style={styles.formFieldItem}>
                    <SearchInput
                      value={name}
                      setValue={setName}
                      placeholder="Navn"
                    />
                  </View>
                  {isBusiness && (
                    <View style={styles.formFieldItem}>
                      <SearchInput
                        value={organizationNr}
                        setValue={setOrganizationNr}
                        placeholder="Organisasjonsnummer"
                      />
                    </View>
                  )}
                </View>
                <View style={styles.formFieldItem}>
                  <SearchInput
                    value={address}
                    setValue={setAddress}
                    placeholder="Adresse"
                  />
                </View>
                <View style={styles.formFieldItem}>
                  <SearchInput
                    value={postCode}
                    setValue={setPostCode}
                    placeholder="Postnummer"
                  />
                </View>
                <View style={styles.formFieldItem}>
                  <SearchInput
                    value={county}
                    setValue={setCounty}
                    placeholder="Fylke"
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
                    value={phoneNumber}
                    setValue={setPhoneNumber}
                    placeholder="Telefonnummer"
                  />
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
                  onPress={handleCreateCustomer}
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
    height: '80%',
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
  switchContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    marginTop: 10,
    marginBottom: 15,
  },
  switchLabel: {
    fontSize: 18,
    marginRight: 10,
    color: '#888',
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

export default NewCustomerModal;
