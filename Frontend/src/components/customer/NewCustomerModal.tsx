import React from 'react';
import {
  View,
  StyleSheet,
  Modal,
  Text,
  TouchableOpacity,
  TouchableWithoutFeedback,
} from 'react-native';

interface Props {
  modalVisible: boolean;
  handleCloseModal: () => void;
}

const NewCustomerModal: React.FC<Props> = ({
  modalVisible,
  handleCloseModal,
}) => {
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

export default NewCustomerModal;
