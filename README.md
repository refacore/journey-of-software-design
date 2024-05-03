# journey-of-software-design

Trong dự án tôi tham gia trước đây, sau khi tôi đề xuất ứng dụng mô hình n-tiers thay thế cấu trúc cũ, cậu em đồng nghiệp đã hỏi tôi rằng "Dùng n-tiers thì mình được lợi gì anh?". Câu hỏi này thực sự làm tôi bối rối. Câu trả lời cho câu hỏi thì rất đơn giản, và nó là câu trả lời cho mọi câu hỏi về Software Design. Mọi cố gắng của chúng ta trong việc thiết kế và cấu trúc mã nguồn để đạt được những tiêu chí sau:
1. Khả năng bảo trì mã nguồn.
2. Khẳ năng tái sử dụng.
3. Khả năng mở rộng chức năng (extensibility).
4. Khả năng kiểm thử.
5. Khả năng mở rộng quy mô (scaling).
6. An toàn và bảo mật.

Chỉ liệt kê những lợi ích kể trên thì thật sáo rỗng và tẻ nhạt. Vì thế tôi viết bài này với mong muốn chúng ta có thể hiểu bối cảnh, động cơ mà các thiết kế phần mềm ra đời.
Tóm tắt thì bài viết chỉ thể hiện lại công việc của chúng ta vẫn làm hằng ngày, nhưng tạo cơ hội cho chúng ta đứng ở góc nhìn người thứ ba để đánh giá và rút ra kết luận.
Phần mã nguồn trong bài viết này sử dụng C# và .net8, api viết theo cách minimal.