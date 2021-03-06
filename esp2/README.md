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

## 默認值
___
默認值在更新Protocol Buffer消息定義的時候有很重要的作用, 他可以防止對現有代碼/新代碼造成破壞性引響.他們可以保證字段永遠不會有null值<br>
但是,默認值是非常危險的: <br>
**你無法區分這個默認值到底是來自一個丟失的字段還是字段的實際值正好等於默認值**


## 枚舉
____
enum 同樣可以進化，就和消息的字段一樣, 可以添加,刪除,也可以保留<br>
但是如果代碼不知道它接收到的值對應到哪個enum值,那麼enum的默認值將會被採用
