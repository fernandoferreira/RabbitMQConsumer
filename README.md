# RabbitMQConsumer

This is a project created for learning purpose.

To run this application, you must to follow the bellow steps. 
1 - Instal the Earlang (last version) that can be found on this link: https://www.erlang.org/downloads
2 - Install the RabbitMQ Server. This will run on localhost and allow you to create and test any kind of queue/message application.
    You can download the server here: https://www.rabbitmq.com/download.html
    
 3 - Once you installed the Erlang and the Server, you can Run your application.
 
 Note: The server has a portal that can be used to check everything about the Exchanges, Queues, etc.
 
 Getting access to the portal:
 
 1 - Go to the "sbin" folder in the installation path, as bellow:
         C:\Program Files\RabbitMQ Server\rabbitmq_server-3.8.19\sbin>
 
 2 - Then, run the follow command: 
        rabbitmq-plugins enable rabbitmq_management
        
        
 After this, you can check all that you need about the queues, just navigate to: http://localhost:15672
 
 You'll be prompted username and password, for this, you can pass "guest" for both, username and password.
 
 That's all.
 
 Enjoy.
