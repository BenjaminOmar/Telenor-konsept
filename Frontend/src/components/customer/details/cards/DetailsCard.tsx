import {View, Text, StyleSheet} from 'react-native';
import React from 'react';
import {CustomerInterface} from '../../../../models/customer/CustomerInterface';
import CustomerDetailsDevider from '../CustomerDetailsDevider';

interface DetailsCardProps {
  details: CustomerInterface;
}

const DetailsCard: React.FC<DetailsCardProps> = ({details}) => {
  return (
    <View style={styles.container}>
      <Text style={styles.title}>Kundeinformasjon</Text>
      <CustomerDetailsDevider />
      <View style={styles.infoRow}>
        <Text style={styles.label}>Status:</Text>
        <Text style={styles.value}>{details.status}</Text>
      </View>
      <View style={styles.infoRow}>
        <Text style={styles.label}>Kundenummer:</Text>
        <Text style={styles.value}>{details.customerNumber}</Text>
      </View>
      <View style={styles.infoRow}>
        <Text style={styles.label}>Organisasjonsnummer:</Text>
        <Text style={styles.value}>{details.organizationNr}</Text>
      </View>
      <View style={styles.infoRow}>
        <Text style={styles.label}>Adresse:</Text>
        <Text style={styles.value}>{details.address}</Text>
      </View>
      <View style={styles.infoRow}>
        <Text style={styles.label}>E-post:</Text>
        <Text style={styles.value}>{details.email}</Text>
      </View>
      <View style={styles.infoRow}>
        <Text style={styles.label}>Telefonnummer:</Text>
        <Text style={styles.value}>{details.phoneNumber}</Text>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    paddingHorizontal: 20,
    marginVertical: 10,
  },
  title: {
    fontSize: 25,
    fontWeight: 'bold',
    textAlign: 'center',
  },
  infoRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginVertical: 5,
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
});

export default DetailsCard;
