import { StatusBar } from 'expo-status-bar';
import React, { useState } from 'react';
import { StyleSheet, Text, View, TextInput, Button } from 'react-native';

export default function App() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  
  const entrar = () => {
    alert('${email} - ${password}');
  }

  return (
    <View style={styles.container}>
      <Text>Email</Text>
      <TextInput
        value={email} 
        onChangeText={(text) => setEmail(text)} 
        style={{ height : 40, width : 200, backgroundColor : 'white', borderColor : 'gray', borderWidth : 1}}/>
      <StatusBar style="auto" />

      <Text>Password</Text>
      <TextInput
        value={password} 
        onChangeText={(text) => setPassword(text)} 
        style={{ height : 40, width : 200, backgroundColor : 'white', borderColor : 'gray', borderWidth : 1}}/>
      <StatusBar style="auto" />

      {/*React 
      <button onClick=(event => entrar(event)} */}
      
      <Button
        onPress = {entrar}
        title = "Entrar"
        color = "#841584"
        acessibilidadeLabel = "Entrar"
      />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
