import {createNativeStackNavigator} from '@react-navigation/native-stack';
import {NavigationContainer} from '@react-navigation/native';
import React, {useState} from 'react';
import {View, StyleSheet} from 'react-native';
import {Button} from '@rneui/base';
import CustomerList from '../../../../components/customer/CustomerList';
import SearchInput from '../../../../components/common/inputs/SearchInput';
import NewCustomerModal from '../../../../components/customer/NewCustomerModal';
import CustomerDetails from './details/CustomerDetails';
import {CustomerInterface} from '../../../../models/customer/CustomerInterface';

type CustomerStackParamList = {
  CustomerList: undefined;
  CustomerDetails: {customer: CustomerInterface};
};

const CustomerStack = createNativeStackNavigator<CustomerStackParamList>();

function Customer() {
  const [modalVisible, setModalVisible] = useState(false);
  const [customerName, setCustomerName] = useState('');
  const [refreshKey, setRefreshKey] = useState(0);

  const handleAddButtonPress = async () => {
    setModalVisible(true);
  };

  const handleCloseModal = () => {
    setModalVisible(false);
  };

  const handleCustomerAdded = () => {
    setRefreshKey(prevKey => prevKey + 1);
  };

  return (
    <NavigationContainer independent={true}>
      <CustomerStack.Navigator initialRouteName="CustomerList">
        <CustomerStack.Screen
          name="CustomerList"
          options={{headerShown: false}}>
          {() => (
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
              <CustomerList search={customerName} refreshKey={refreshKey} />
              <NewCustomerModal
                modalVisible={modalVisible}
                handleCloseModal={handleCloseModal}
                onCustomerAdded={handleCustomerAdded}
              />
            </View>
          )}
        </CustomerStack.Screen>
        <CustomerStack.Screen
          name="CustomerDetails"
          component={CustomerDetails}
          options={{
            headerShown: false,
          }}
        />
      </CustomerStack.Navigator>
    </NavigationContainer>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    marginTop: 10,
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

export default Customer;
