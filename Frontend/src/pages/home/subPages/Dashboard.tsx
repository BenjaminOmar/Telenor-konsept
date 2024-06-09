import React from 'react';
import {ScrollView, StyleSheet, Text, View} from 'react-native';
import RegisteredBusinesses from '../../../components/dashboard/graphs/RegisteredBusinesses';

const Dashboard = () => {
  return (
    <ScrollView contentContainerStyle={styles.scrollViewContent}>
      <RegisteredBusinesses />
    </ScrollView>
  );
};

const styles = StyleSheet.create({
  scrollViewContent: {
    padding: 0,
  },
});

export default Dashboard;
