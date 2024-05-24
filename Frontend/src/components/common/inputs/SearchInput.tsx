import {View, TextInput, StyleSheet} from 'react-native';
import React from 'react';

interface Props {
  value: string;
  setValue: (value: string) => void;
  placeholder: string;
}

const SearchInput: React.FC<Props> = ({value, setValue, placeholder}) => {
  return (
    <View style={styles.container}>
      <TextInput
        value={value}
        onChangeText={setValue}
        style={styles.input}
        placeholder={placeholder}
        autoCapitalize="none"
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    width: '100%',
    alignItems: 'center',
  },
  input: {
    borderWidth: 1,
    backgroundColor: '#FFFFFF',
    borderColor: '#ADD8E6',
    borderRadius: 10,
    width: 240,
    padding: 15,
    fontSize: 16,
  },
});

export default SearchInput;
