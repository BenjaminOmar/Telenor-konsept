import {View, Text, StyleSheet} from 'react-native';
import React from 'react';

const CustomerDetailsDevider = () => {
  return <View style={styles.divider} />;
};

const styles = StyleSheet.create({
  divider: {
    width: '80%',
    height: 3,
    borderRadius: 10,
    alignSelf: 'center',
    backgroundColor: '#CED0CE',
    marginVertical: 5,
  },
});

export default CustomerDetailsDevider;
