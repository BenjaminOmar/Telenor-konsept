import {View, Text, Pressable, StyleSheet} from 'react-native';
import React from 'react';

interface Props {
  text: string;
  onPress: () => void;
}

const CustomButton: React.FC<Props> = ({onPress, text}) => {
  return (
    <Pressable onPress={onPress} style={styles.buttonContainer}>
      <Text style={styles.buttonText}>{text || 'Knapp'}</Text>
    </Pressable>
  );
};

const styles = StyleSheet.create({
  buttonContainer: {
    backgroundColor: '#00ACE7',
    paddingVertical: 15,
    paddingHorizontal: 20,
    borderRadius: 10,
    alignItems: 'center',
    justifyContent: 'center',
    shadowColor: '#000',
    shadowOffset: {width: 0, height: 2},
    shadowOpacity: 0.1,
    shadowRadius: 2,
    elevation: 3,
    cursor: 'pointer',
    width: 280,
  },
  buttonText: {
    color: 'white',
    fontSize: 16,
    fontWeight: 'bold',
  },
});

export default CustomButton;
