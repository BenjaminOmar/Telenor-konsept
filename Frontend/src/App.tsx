import {createNativeStackNavigator} from '@react-navigation/native-stack';
import React from 'react';

import Logo from '../assets/images/telenor-logo.png';
import {Image, SafeAreaView, StyleSheet, Text, View} from 'react-native';
import {QueryClient, QueryClientProvider} from 'react-query';
import Login from './pages/Login';
import {AuthProvider, useAuth} from './context/authContext';
import Home from './pages/Home';

const Stack = createNativeStackNavigator();

const queryClient = new QueryClient();

const App = () => {
  return (
    <AuthProvider>
      <Layout></Layout>
    </AuthProvider>
  );
};

export const Layout = () => {
  const {authState, onLogout} = useAuth();
  return (
    <QueryClientProvider client={queryClient}>
      <Stack.Navigator initialRouteName="Login">
        {authState?.authenticated ? (
          <Stack.Screen
            name="Home"
            component={Home}
            options={{
              headerRight: () => (
                <SafeAreaView>
                  <Text onPress={onLogout}>Logg ut</Text>
                </SafeAreaView>
              ),
              headerTitle: () => (
                <Image
                  source={Logo}
                  style={{width: 40, height: 40}}
                  resizeMode="contain"
                />
              ),
            }}
          />
        ) : (
          <Stack.Screen
            options={{headerShown: false}}
            name="Login"
            component={Login}
          />
        )}
      </Stack.Navigator>
    </QueryClientProvider>
  );
};

export default App;
