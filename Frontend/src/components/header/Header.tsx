import React from 'react';
import {SafeAreaView, StyleSheet, Text, View} from 'react-native';
import {useAuth} from '../../context/authContext';
import HeaderMenu from './HeaderMenu';

function header() {
  return <Header />;
}

export const Header = () => {
  const {onLogout} = useAuth();
  return (
    <SafeAreaView>
      <View style={styles.headerMenu}>
        <HeaderMenu />
      </View>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  root: {},
  headerMenu: {
    flexDirection: 'row',
    justifyContent: 'flex-end',
    paddingRight: 30,
    paddingTop: 20,
  },
});

export default header;
