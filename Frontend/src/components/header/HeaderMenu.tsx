import {View, Text} from 'react-native';
import React from 'react';
import {useAuth} from '../../context/authContext';
import {Avatar} from '@rneui/base';
import Profilbilde from '../../../assets/images/profilbilde.png';

const HeaderMenu = () => {
  const {onLogout} = useAuth();
  return (
    <>
      <Avatar size={50} rounded source={Profilbilde} onPress={onLogout} />
    </>
  );
};

export default HeaderMenu;
