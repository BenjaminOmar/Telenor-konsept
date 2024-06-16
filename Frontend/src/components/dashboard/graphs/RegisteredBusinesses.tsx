import {View, Text, StyleSheet} from 'react-native';
import React from 'react';

const RegisteredBusinesses = () => {
  return (
    <>
      <View style={styles.card}>
        <Text style={styles.title}>Graf over bedrifter</Text>
        <Text>
          Her kan vi ha en graf som viser statestikk over registrerte bedrifter.
          Dette kan feks være en bar chart som viser leads vs i prosess vs
          kunder
        </Text>
      </View>
      <View style={styles.card}>
        <Text style={styles.title}>Vise bedriftens fortjeneste</Text>
        <Text>Vise tallet for hvor mye bedriften har solgt for</Text>
      </View>
      <View style={styles.card}>
        <Text style={styles.title}>Vise antallet utførte oppgaver</Text>
        <Text>
          Vise tallet for hvor mange oppgaver som er utført hos bedriften
        </Text>
      </View>
    </>
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
