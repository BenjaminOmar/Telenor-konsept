import {View, Text, StyleSheet} from 'react-native';
import React from 'react';
import {CustomerInterface} from '../../../models/customer/CustomerInterface';

interface DetailsCardProps {
  details: CustomerInterface;
}

const DetailsCard: React.FC<DetailsCardProps> = ({details}) => {
  return (
    <View style={styles.card}>
      <Text style={styles.title}>Kundeinformasjon</Text>
      <View style={styles.infoRow}>
        <Text style={styles.label}>Kundenummer:</Text>
        <Text style={styles.value}>{details.customerNumber}</Text>
      </View>
      <View style={styles.infoRow}>
        <Text style={styles.label}>Privatkunde:</Text>
        <Text style={styles.value}>
          {details.isPrivateCustomer ? 'Ja' : 'Nei'}
        </Text>
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
  card: {
    width: '90%',
    padding: 20,
    marginVertical: 10,
    marginHorizontal: '5%',
    backgroundColor: '#fff',
    borderRadius: 10,
    shadowColor: '#000',
    shadowOffset: {width: 0, height: 2},
    shadowOpacity: 0.2,
    shadowRadius: 4,
    elevation: 5,
  },
  title: {
    fontSize: 25,
    fontWeight: 'bold',
    textAlign: 'center',
    marginBottom: 10,
  },
  infoRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginVertical: 5,
  },
  label: {
    fontWeight: 'bold',
    fontSize: 16,
    color: '#333',
  },
  value: {
    color: '#555',
  },
});

export default DetailsCard;
