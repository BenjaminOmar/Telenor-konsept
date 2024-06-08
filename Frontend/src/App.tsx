import {createNativeStackNavigator} from '@react-navigation/native-stack';
import React from 'react';
import {Image, SafeAreaView, StyleSheet, Text, View} from 'react-native';
import {QueryClient, QueryClientProvider} from 'react-query';
import Login from './pages/Login';
import {AuthProvider, useAuth} from './context/authContext';
import Home from './pages/Home';
import {SafeAreaProvider} from 'react-native-safe-area-context';
import CustomerDetails from './pages/CustomerDetails';
import CustomerList from './components/customer/CustomerList';
import {StackParamList} from './routing/StackNavigatiorConfig';
import {HeaderProvider} from './context/HeaderContext';

const Stack = createNativeStackNavigator<StackParamList>();

const queryClient = new QueryClient();

const App = () => {
  return (
    <AuthProvider>
      <HeaderProvider>
        <Layout />
      </HeaderProvider>
    </AuthProvider>
  );
};

export const Layout = () => {
  const {authState, onLogout} = useAuth();
  return (
    <SafeAreaProvider>
      <QueryClientProvider client={queryClient}>
        <Stack.Navigator initialRouteName="Login">
          {authState?.authenticated ? (
            <Stack.Screen
              name="Home"
              component={Home}
              options={{headerShown: false, animation: 'fade'}}
            />
          ) : (
            <Stack.Screen
              options={{headerShown: false, animation: 'fade'}}
              name="Login"
              component={Login}
            />
          )}
        </Stack.Navigator>
      </QueryClientProvider>
    </SafeAreaProvider>
  );
};

const config = {
  animation: 'spring',
  config: {
    stiffness: 1000,
    damping: 50,
    mass: 3,
    overshootClamping: false,
    restDisplacementThreshold: 0.01,
    restSpeedThreshold: 0.01,
  },
};

export default App;
