// src/components/header/Header.tsx
import React from 'react';
import {
  SafeAreaView,
  StyleSheet,
  Text,
  View,
  TouchableOpacity,
} from 'react-native';
import HeaderMenu from './HeaderMenu';
import {useHeader} from '../../context/HeaderContext';

const truncateTitle = (title: string, maxLength: number) => {
  return title.length > maxLength
    ? title.substring(0, maxLength) + '...'
    : title;
};

const Header: React.FC = () => {
  const {headerTitle, showGoBack, handleGoBack} = useHeader();
  const truncatedTitle = truncateTitle(headerTitle, 13);

  return (
    <SafeAreaView>
      <View style={styles.headerContainer}>
        <View style={styles.headerTitleContainer}>
          {showGoBack && handleGoBack && (
            <TouchableOpacity onPress={handleGoBack} style={styles.backButton}>
              <Text style={styles.backButtonText}>Go Back</Text>
            </TouchableOpacity>
          )}
          <Text style={styles.headerText}>{truncatedTitle}</Text>
        </View>
        <View style={styles.headerMenu}>
          <HeaderMenu />
        </View>
      </View>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  headerContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    paddingHorizontal: 20,
    paddingTop: 10,
    marginBottom: 20,
  },
  headerTitleContainer: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  backButton: {
    marginRight: 10,
  },
  backButtonText: {
    color: '#007AFF',
    fontSize: 16,
  },
  headerText: {
    fontSize: 34,
    fontWeight: 'bold',
    color: '#00ACE7',
  },
  headerMenu: {
    flexDirection: 'row',
    justifyContent: 'flex-end',
  },
});

export default Header;
