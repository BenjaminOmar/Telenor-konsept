import {View, Text} from 'react-native';
import React from 'react';
import {CustomerInterface} from '../../../models/customer/CustomerInterface';

interface DetailsCardProps {
  customer: CustomerInterface;
}

const DetailsCard = ({details}: {details: CustomerInterface}) => {
  return (
    <View>
      <Text>{details.name}</Text>
    </View>
  );
};

export default DetailsCard;
