import React from 'react';
import {
  Text,
  View,
  Image,
  StyleSheet,
  useWindowDimensions,
  TouchableOpacity,
  Alert,
} from 'react-native';
import Logo from './../../assets/images/telenor-logo-text.png';
import CustomInput from '../components/common/inputs/CustomInput';
import CustomButton from '../components/common/buttons/CustomButton';
import {useState} from 'react';
import {useAuth} from '../context/authContext';

const Login = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const {onLogin} = useAuth();

  const login = async () => {
    const result = await onLogin!(username, password);
    if (result && result.error) {
      Alert.alert(result.errorMessage);
    }
  };

  const OnForgotPasswordPressed = () => {
    console.log('Forgot password pressed');
  };

  const {height} = useWindowDimensions();
  return (
    <View style={styles.root}>
      <Image
        source={Logo}
        style={[styles.logo, {height: height * 0.3}]}
        resizeMode="contain"
      />
      <View style={styles.inputContainer}>
        <CustomInput
          placeholder="Brukernavn"
          value={username}
          setValue={setUsername}
          secureTextEntry={false}
        />
      </View>
      <View style={styles.inputContainer}>
        <CustomInput
          placeholder="Passord"
          value={password}
          setValue={setPassword}
          secureTextEntry={true}
        />
      </View>
      <View style={styles.buttonContainer}>
        <CustomButton onPress={login} text={'Logg inn'} />
      </View>
      <TouchableOpacity onPress={OnForgotPasswordPressed}>
        <Text style={styles.linkText}>Glemt passord?</Text>
      </TouchableOpacity>
    </View>
  );
};

const styles = StyleSheet.create({
  root: {
    alignItems: 'center',
    paddingTop: 100,
  },
  logo: {
    width: '80%',
    maxHeight: 250,
    maxWidth: 400,
    marginBottom: -20,
  },
  inputContainer: {
    marginBottom: 20,
  },
  buttonContainer: {
    marginTop: 5,
  },
  linkText: {
    color: '#007AFF',
    marginTop: 25,
    fontWeight: '500',
    fontSize: 16,
  },
});

export default Login;
