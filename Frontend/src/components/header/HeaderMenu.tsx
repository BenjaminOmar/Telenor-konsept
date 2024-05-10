import {View, Text} from 'react-native';
import React from 'react';
import {useAuth} from '../../context/authContext';
import {Avatar} from '@rneui/base';

const HeaderMenu = () => {
  const {onLogout} = useAuth();
  return (
    <>
      <Avatar
        size={50}
        rounded
        source={{uri: 'https://randomuser.me/api/portraits/men/36.jpg'}}
        onPress={onLogout}
      />
      {/* <View>
        <Text onPress={onLogout}>Logg ut</Text>
      </View> */}
    </>
  );
};

export default HeaderMenu;
