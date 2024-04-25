import {createNativeStackNavigator} from '@react-navigation/native-stack';
import React from 'react';

import {SafeAreaView, StyleSheet} from 'react-native';
import Dashboard from './pages/Dashboard';
import {QueryClient, QueryClientProvider} from 'react-query';
import Login from './pages/Login';

const Stack = createNativeStackNavigator();

const queryClient = new QueryClient();

const App = () => {
  return (
    <QueryClientProvider client={queryClient}>
      <Stack.Navigator initialRouteName="Login">
        <Stack.Screen name="Dashboard" component={Dashboard} />
        <Stack.Screen
          options={{headerShown: false}}
          name="Login"
          component={Login}
        />
      </Stack.Navigator>
    </QueryClientProvider>
  );
};

export default App;
