## 如何學習 gRPC
___
1. Protocol Buffers, 簡單的來說, 它可以用來定義消息和服務
1. 你只需要實現服務即可,剩下的gRPC代碼將自動為你生成
1. .proto(用來定義消息和服務的文件), 這個文件可以適用於十幾種語言( 包括服務端和客戶端)

## 步驟
___
1. 安裝 CLang 編譯器
1. 安裝插件 vscode-proto3 (vs code 插件)
1. 安裝插件 Clang-Format  (vs code 插件)

## 標量類型
___
1. 數值型
1. 布林型
1. 字符型
1. 字節型

## 字段
___
* 在 Protocol Buffers 裡面, 字段名其實沒那麼重要, 但是在寫 C# 代碼的時候, 字段名還是很重要的
* 對於 protobuf, 這個 tag 是更重要的
* 從1到15的 Tag 數只占用1個字節的空間,所以他們應該被用在頻繁使用的字段, 從 16 到 2047 則佔用兩個字節, 他們可以使用在不頻繁使用的字段上
* 字段規則
    - 單數字段 (Singular)
        - 這個字段只能出現0次或1次(不能超過1次),這也是proto3的默認字段規則
    - 多數字段 (Repeated)
        - 與 Singular 相對的就是 repeated. 如果你想做一個list或數組的話,你可以使用重複字段這個概念.這個list可以有任何數量(包括0)的元素.它裡面的值的順序將會得到保留.
* 保留字段 or 數值
    - reserved
* 字段的默認值
    - string: 空字符串
    - bytes: 空的 btye 數組
    - bool: false
    - 數值型: 0 
    - 枚舉 enum: 枚舉裡定義的第一個枚舉值, 值必須是0
    - repeated: 通常是相對應開發語言裡的空list

## 枚舉
___
* 枚舉例子
    ```proto3
    enum Gender {
        option allow_alias = true;
        NOT_SPECIFIED = 0;
        FEMALE = 1;
        MALE = 2;
        WOMAN = 1;
        MAN = 2;    

        reserved 9, 10, 20 to 100, 200 to max;
        reserved "BOY", "GIRL";
    }
    ```
* 枚舉值起別名
    - 起別名的作用是允許兩個枚舉值擁有同一個數值
    - 要想起別名,首先需要設置allow_alias這個option為true


## 更新消息類型
___

有一些字段可能會發生變化,可能會添加一些字段,也可能會刪除一些字段.
但是可能有很多程序正在使用/讀取你的Protocol Buffer的消息,但是它們沒辦法都隨著需求進行更新.
所以,在你對原數據進行演進的時候,一定不要引起破壞性變化,否則其他的程序可能就無法正常運作了.

* 兩種變更情景
    * 向前兼容變更: 使用新的.proto文件來寫數據 -- 從舊的.proto文件讀取數據
    * 向後兼容變更: 使用舊的.proto文件來寫數據 -- 從新的.proto文件讀取數據

* 更新消息類型的規則
    * 不要修改任何現有字段的數字 (tag)
    * 你可以使用新的消息字段,那些使用舊的消息格式的代碼仍然可以將消息序列化,你可以注意這些元素的默認值,以便新代碼可以與舊代碼生成的消息正確交互.類似的,新代碼所創建的消息也可以被救代碼解析:舊的二進制在解析的時候會忽略新的字段.
    * 字段可以被刪除,只要他們的數字(tag)在更新後的消息類型中不再使用即可.你也可以把字段改成


## 設置 protocol buffer 編譯器
___
1. https://github.com/protocolbuffers/protobuf/releases
1. 下載編譯器,並把他加入環境變數內
1. 下命令
    > protoc first.proto --csharp_out=csharp <br>
    > protoc *.proto --csharp_out=csharp