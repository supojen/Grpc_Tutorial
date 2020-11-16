## GRPC 簡介
___
![image](..\img\GRPC.png)
<br><br><br>
![image](..\img\DesignProcess.png)
<br><br><br>
![image](..\img\LifeCycle.png)
<br><br><br>


<br><br><br>

## 身分認證
___
這裡指的不是用戶的身分認證,而是指多個server和client之間,它們如何識別出來誰是誰,並且能安全的進行消息傳輸.<br>

在身分認證這方面,gRPC一共有4種身分認證的機制:
1. 不採取任何措施的連接, 也就是不安全連接
1. TLS/SSL 連接
1. 基於 Google Token 的身分認證
1. 自定義的身分認證提供商


<br><br><br>

## 傳輸消息類型
___
1. 請求響應
    ![image](..\img\1.png)

1. server streaming 
    ![image](..\img\2.png)

1. client streaming
    ![image](..\img\3.png)

1. 雙向 streaming
    ![image](..\img\4.png)



<br><br><br>

## 消息類型
___
當 gRPC 使用 Protocol Buffer 作為傳輸協定的時候, Protocol Buffer 裡面所有的規則仍然適用 <br>
但是在 gRPC 使用 Protocol Buffer 的時候, 會添加一些額外的規則和語法, 以便讓 gRPC 能和它完美配合

![image](..\img\5.png)