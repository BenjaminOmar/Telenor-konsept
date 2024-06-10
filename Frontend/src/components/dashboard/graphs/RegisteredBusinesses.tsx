import {View, Text, StyleSheet} from 'react-native';
import React from 'react';

const RegisteredBusinesses = () => {
  return (
    <View style={styles.card}>
      <Text style={styles.title}>Nye bedrifter</Text>
      <Text>
        Her kommer informasjon om hvordan bedriften gjør det økonomisk. Dette er
        blant annet likviditetsgrad, lønnsomhet og soliditet. Her kan det brukes
        api som henter data fra regnskapssystemet, brreg eller feks proff.no.
      </Text>
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
    borderRadius: 20,
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
});

export default RegisteredBusinesses;
