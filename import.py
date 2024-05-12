import socket 

localIP     ='192.168.50.110'
localPort   = 20001
bufferSizq  = 1024

msgFromServer     = 'БАНЖУР ЁПТА'
bytesToSend       = str.encode(msgFromServer)


UDPServerSocket = socket.socket(family=socket.AF_INET, type=socket.SOCK_DGRAM)
UDPServerSocket.bind((localIP,localPort))

print('UPD server up and listening')


while(True):
    bytesAddressPair=UDPServerSocket.recvfrom(bufferSizq)
    message=bytesAddressPair[0]
    address=bytesAddressPair[1]
    clientMsg='Message from Client:{}'.format(message.decode('utf-8'))
    clientIP='Cliet IP Address:{}'.format(address)
    print(clientMsg)
    print(clientIP)


    UDPServerSocket.sendto(bytesToSend,address)
