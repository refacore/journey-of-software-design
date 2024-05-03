## Bối cảnh
Sau khi api của chúng ta đi vào hoạt động một thời gian, khách hàng thích nó và muốn nâng cấp nó một chút. Khách hàng muốn lưu lại kết quả các lần gọi api xuống database để có thể sử dụng vào các việc khác sau này.

Chúng ta đề xuất lưu xuống Sql database và gọi hàm SaveResult trước khi trả về kết quả cho client.

## Đánh giá
CR là một phần cuộc sống của lập trình viên. CR là khẳng định cho đời sống của các hệ thống phần mềm. Có hoạt động, có giá trị nên các hệ thống mới có yêu cầu thay đổi cũng như yêu cầu chức năng mới. Và một lập trình viên lão luyện cần tính toán trước những khả năng.

Code hiện tại chỉ thêm một hàm private SaveResult kết nối trực tiếp đến DB. Các bạn chắc chắn đã nhận ra điểm yếu của giải pháp này và đã có trong đầu phác thảo cách để làm nó tốt hơn. Hàm private này, theo dụng ý của tôi, là chúng ta đã quay lại với bước đầu tien trong lập trình: viết một phiên bản chạy được. Chúng ta lại quay lại 01-runable, và tiếp tục một vòng lặp đến hết vòng đời sản phẩm. Vòng lặp này là không thể tránh khỏi. Mỗi dòng code chúng ta viết ra không chết cứng ở đó mà chúng ta sẽ còn quay lại với nó nhiều lần. Vì thế, bạn là một coder lão làng sẽ luôn biết cách làm cho cuộc sống dễ dàng hơn bằng cách nỗ lực làm những dòng code chỉn chu ngay từ những bước đầu tiên nhất.

Chúng ta sẽ tiếp tục refactor hàm SaveResult để BubbleSortCommand vẫn testable, cấu trúc chuwong trình vẫn mềm dẻo dễ mở rộng và độc lập, thậm chí có thể thay đổi sử dụng bất cứ database nào về sau mà không phá hỏng code sẵn có. Và lúc đó chúng ta có được một DESIGN tương đối hoàn thiện. Nó giải đáp câu hỏi của cậu em đồng nghiệp tôi lúc đầu: n-tiers thì nhận được lợi gì.

Có một điều mà chúng ta có thể cảm thấy, đó là liệu thiết kế ở bước 06 có thực sự tốt hơn bước 05, hay bước 03? Đối với tôi, 06 tốt hơn 05, nhưng so với 03 thì có phần đánh đổi. Tất nhiên từ quan điểm cá nhân tôi thì đánh đổi này là đáng giá. Đối với các dự án lớn với số lượng lớn lập trình viên tham gia, và đặc biệt cho các sản phẩm dài hơi, thiết kế chặt chẽ hơn như bước 06 đem lại sự an toàn cho mã nguồn. Sẽ khó để những dòng code lạ tham gia vào dự án.

## Kết
Các bạn thân mến, các design patterns, các mô hình lập trình không phải do ai phát minh ra, cũng ko phải những giải pháp có trước. Chúng được đúc kết từ kinh nghiệm của các lập trình viên qua hàng chục năm làm việc, và qua đó, các lập trình viên hiểu rằng khi áp dụng chúng, họ sẽ nhận được những giá trị mà tất cả chúng ta đều đồng ý rằng nó quan trọng cho phát triển phần mềm:

1. Khả năng bảo trì mã nguồn.
2. Khẳ năng tái sử dụng.
3. Khả năng mở rộng chức năng (extensibility).
4. Khả năng kiểm thử.
5. Khả năng mở rộng quy mô (scaling).
6. An toàn và bảo mật.

### Mọi Nhà phát triển đều là lập trình viên, nhưng không phải lập trình viên nào cũng là nhà phát triển.
Biết về design pattern và các mô hình lập trình là yêu cầu cần phải có đối với các nhóm lập trình viên khác nhau. Chúng ta có Web Developer, Game Developer, Embeded Developer ... Với mỗi nhóm lập trình viên lại có những pattern, mô hình khác nhau cần phải biết. Có lẽ cái danh "Nhà phát triển" dựa trên phần nào yêu cầu ấy. Mọi developer đều là programmer, nhưng không phải mọi programmer đều là developer. Về mặt nghề nghiệp, ý tưởng này có thể giúp các bạn hiểu được lộ trình sự nghiệp của mình.

### Sinh con rồi mới sinh cha. Sinh cháu giữ nhà rồi mới sinh ông.
Hãy luôn nhớ rằng, pattern hay paradigm đều từ kinh nghiệm mà ra, tức là qua thực tiễn, đặc biệt là design pattern. Các vấn đề sinh ra các pattern, không phải ngược lại. Các mô hình có đặc tả lý thuyết dễ hiểu hơn so với Design Pattern, do Design Pattern đi vào những vấn đề chi tiết. Điều này có thể chỉ ra một con đường để các bạn nghiên cứu Design Pattern dễ hơn. Đừng cố gắng học thuộc các pattern hay pattern này áp dụng cho trường hợp nào. Hãy tập trung vào vấn đề mà pattern muốn giải quyết, và điều còn lại là thực hành. Một cách thực hành là hãy đọc thật nhiều code. Đọc Design Pattern sẽ giúp chúng ta học được cách giải quyết vấn đề. Đến khi gặp vấn đề, hãy tìm giải pháp, đừng tìm pattern.

### Có nhiều thiết kế có thể đáp ứng một bài toán, và bạn phải tìm ra càng nhiều càng tốt.
Mỗi thiết kế đều có ưu nhược điểm. Thiết kế được lựa chọn nên tối ưu giá trị cho sản phẩm, dựa trên các nguồn lực hiện có của đội.
Có những tham số ngoài kĩ thuật tham gia vào quyết định thiết kế của bạn:

- Ưu tiên tốc độ phát triển hay ổn định.
- Nguồn lực tài chính.
- Trình độ đồng nghiệp.
- Deadline.

Tôi sẽ cố gắng đi chi tiết vào từng yếu tố trong những bài về sau.

### Thiết kế sự tiến hóa.
Có những dự án lớn và có những dự án nhỏ. Chúng ta đều muốn làm những dự án lớn, thiết kế những hệ thống lớn. Nhưng các hệ thống có sự phát triển và tiến hóa của nó dù lớn hay nhỏ. Có những hệ thống nhỏ thành lớn. Có những hệ thống lớn thành vĩ đại. Tất cả các hệ thống thì đều bắt đầu từ một MVP - Minimum Viable Product. Tôi thấy trong nhiều dự án, mọi người mải mê suy tưởng đến sự vĩ đại của sản phẩm. Rất nhiều dự án trở nên bất ổn khi không xác định được MVP mà tập trung vào hệ thống tương lai. Cũng có dự án xác định được MVP nhưng lại quá khiêm tốn khi thiết kế, thu hẹp cánh của của nó trong tương lai.

Bạn thân mến, vì lẽ đó chúng ta có thể nhận biết đâu là kĩ sư xuất chúng. Một thiết kế tốt là một thiết kế hợp thời nhưng luôn chuẩn bị sẵn cho tương lai. Sản phẩm của bạn hướng tới cả triệu người dùng, nhưng nó sẽ bắt đầu phục vụ một nhóm nhỏ vài trăm, rồi vài nghìn, rồi vài chục nghìn và tiếp tục tăng lên. Thiết kế ngay một hệ thống phục vụ cả triệu người dùng sẽ khiến bạn hết vốn nhanh chóng. Thiết kế một hệ thống phục vụ vài nghìn người dùng sẽ có thể khiến bạn rắc rối lớn khi sản phẩm bùng nổ. Lý lẽ này có lẽ không mới. Nghĩ lớn làm nhỏ. Nhưng nhỏ này là nhỏ có võ nhé.

### Code sạch sẽ có thể không bá đạo, nhưng code bá đạo chắc chắn là sạch sẽ.
Thế nên nếu code của bạn còn rối rắm thì bạn biết mình cần cải thiện điều gì rồi đấy. Vở sạch chữ đẹp không phải là một tiêu chí phụ, mà có khi lại là tiêu chí tiên quyết.
