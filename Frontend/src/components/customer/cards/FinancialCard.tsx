import {View, Text, StyleSheet} from 'react-native';
import React from 'react';
import CustomerDetailsDevider from '../CustomerDetailsDevider';

const FinancialCard = () => {
  return (
    <View style={styles.container}>
      <Text style={styles.title}>Finansiell informasjon</Text>
      <CustomerDetailsDevider />
      <Text style={styles.description}>
        Her kommer informasjon om hvordan bedriften gjør det økonomisk. Dette er
        blant annet likviditetsgrad, lønnsomhet og soliditet. Her kan det brukes
        api som henter data fra regnskapssystemet, brreg eller feks proff.no.
      </Text>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    paddingHorizontal: 20,
  },
  title: {
    fontSize: 25,
    fontWeight: 'bold',
    textAlign: 'center',
    marginBottom: 0,
  },
  description: {
    fontSize: 16,
    color: '#555',
  },
});

export default FinancialCard;
