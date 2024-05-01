import {createContext, useContext, useEffect, useState} from 'react';
import axios, {AxiosError} from 'axios';
import AsyncStorage from '@react-native-async-storage/async-storage';

interface AuthProps {
  authState?: {token: string | null; authenticated: boolean | null};
  onLogin?: (username: string, password: string) => Promise<any>;
  onLogout?: () => Promise<any>;
}

const ACCESS_TOKEN = 'access_token';
export const BaseUrl = 'http://localhost:3000/api';
const AuthContext = createContext<AuthProps>({});

export const useAuth = () => {
  return useContext(AuthContext);
};

export const AuthProvider = ({children}: any) => {
  const [authState, setAuthState] = useState<{
    token: string | null;
    authenticated: boolean | null;
  }>({
    token: null,
    authenticated: null,
  });

  useEffect(() => {
    const loadToken = async () => {
      const token = await AsyncStorage.getItem(ACCESS_TOKEN);
      if (token) {
        axios.defaults.headers.common['Authorization'] = `Bearer ${token}`;
        setAuthState({token, authenticated: true});
      } else {
        setAuthState({token: null, authenticated: false});
      }
    };
    loadToken();
  }, []);

  const login = async (username: string, password: string) => {
    try {
      const response = await axios.post(`${BaseUrl}/auth/login`, {
        username,
        password,
      });
      const token = response.data.accessToken;
      setAuthState({token, authenticated: true});
      axios.defaults.headers.common['Authorization'] = `Bearer ${token}`;
      await AsyncStorage.setItem(ACCESS_TOKEN, token);
      return response;
    } catch (error) {
      console.error('--------------------');
      console.error(error);
    }
  };

  const logout = async () => {
    try {
      await AsyncStorage.removeItem(ACCESS_TOKEN);
      axios.defaults.headers.common['Authorization'] = '';
      setAuthState({token: null, authenticated: false});
    } catch (error) {
      console.error(error);
    }
  };

  const value = {
    onLogin: login,
    onLogout: logout,
    authState,
  };
  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};
