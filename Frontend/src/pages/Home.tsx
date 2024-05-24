import {View, Text} from 'react-native';
import React from 'react';
import Dashboard from './Dashboard';
import {NavigationContainer} from '@react-navigation/native';
import {createBottomTabNavigator} from '@react-navigation/bottom-tabs';
import Tasks from './Tasks';
import Ionicons from 'react-native-vector-icons/Ionicons';
import AntDesign from 'react-native-vector-icons/AntDesign';
import FontAwsome5 from 'react-native-vector-icons/FontAwesome';
import Header from '../components/header/Header';
import Customer from './Customer';

const Tab = createBottomTabNavigator();

const Home = () => {
  return (
    <>
      <Header />
      <Tab.Navigator
        initialRouteName="Dashbord"
        screenOptions={{
          tabBarShowLabel: false,
          headerShown: false,
          tabBarActiveTintColor: '#007AFF',
        }}>
        <Tab.Screen
          name="Bedriftsliste"
          component={Customer}
          options={{
            tabBarIcon: ({color, size}) => (
              <Ionicons name="business" size={size} color={color} />
            ),
          }}
        />
        <Tab.Screen
          name="Dashbord"
          component={Dashboard}
          options={{
            tabBarIcon: ({color, size}) => (
              <AntDesign name="dashboard" size={size} color={color} />
            ),
          }}
        />
        <Tab.Screen
          name="Oppgaver"
          component={Tasks}
          options={{
            tabBarIcon: ({color, size}) => (
              <FontAwsome5 name="tasks" size={size} color={color} />
            ),
          }}
        />
      </Tab.Navigator>
    </>
  );
};

export default Home;
