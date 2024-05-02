import React from 'react';
import {SafeAreaView, StyleSheet, Text, View} from 'react-native';
import {useAuth} from '../context/authContext';

function header() {
  return <BurgerMenu />;
}

export const BurgerMenu = () => {
  const {authState, onLogout} = useAuth();
  return (
    <SafeAreaView>
      <Text onPress={onLogout}>Logg ut</Text>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  root: {},
});

export default header;
