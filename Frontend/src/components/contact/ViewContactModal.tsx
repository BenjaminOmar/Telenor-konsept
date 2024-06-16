import React from 'react';
import {
  View,
  StyleSheet,
  Modal,
  Text,
  TouchableWithoutFeedback,
  ScrollView,
} from 'react-native';
import {Button} from '@rneui/base';

interface Props {
  contact: {
    name: string;
    email: string;
    phoneNumber: string;
    position: string;
  } | null;
  modalVisible: boolean;
  handleCloseModal: () => void;
}

const ViewContactModal: React.FC<Props> = ({
  contact,
  modalVisible,
  handleCloseModal,
}) => {
  if (!contact) return null;

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
              <Text style={styles.headerText}>{contact.name}</Text>
              <View style={styles.divider} />
              <ScrollView
                style={styles.scrollContainer}
                contentContainerStyle={styles.scrollContentContainer}
                persistentScrollbar={true}>
                <View style={styles.formContainer}>
                  <View style={styles.infoRow}>
                    <Text style={styles.label}>Navn:</Text>
                    <Text style={styles.value}>{contact.name}</Text>
                  </View>
                  <View style={styles.infoRow}>
                    <Text style={styles.label}>Telefonnummer:</Text>
                    <Text style={styles.value}>{contact.phoneNumber}</Text>
                  </View>
                  <View style={styles.infoRow}>
                    <Text style={styles.label}>Epost:</Text>
                    <Text style={styles.value}>{contact.email}</Text>
                  </View>
                  <View style={styles.infoRow}>
                    <Text style={styles.label}>Posisjon:</Text>
                    <Text style={styles.value}>{contact.position}</Text>
                  </View>
                </View>
              </ScrollView>
              <View style={styles.buttonContainer}>
                <Button
                  title="Lukk"
                  buttonStyle={styles.closeButton}
                  containerStyle={styles.button}
                  onPress={handleCloseModal}
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
    textAlign: 'center',
  },
  modalContent: {
    width: '90%',
    height: '38%',
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
  infoRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginVertical: 5,
    width: '100%',
    paddingHorizontal: 20,
  },
  label: {
    fontWeight: 'bold',
    fontSize: 18,
    color: '#333',
  },
  value: {
    color: '#555',
    fontSize: 18,
  },
  buttonContainer: {
    alignSelf: 'flex-end',
  },
  button: {
    marginHorizontal: 5,
  },
  closeButton: {
    backgroundColor: '#00ACE7',
    borderRadius: 10,
    width: 90,
    height: 47,
  },
});

export default ViewContactModal;
