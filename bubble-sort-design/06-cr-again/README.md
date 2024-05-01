## Bối cảnh
Sau khi api của chúng ta đi vào hoạt động một thời gian, khách hàng thích nó và muốn nâng cấp nó một chút. Khách hàng muốn lưu lại kết quả các lần gọi api xuống database để có thể sử dụng vào các việc khác sau này.
Chúng ta đề xuất lưu xuống Sql database và gọi hàm SaveResult trước khi trả về kết quả cho client.
## Đánh giá
CR là một phần cuộc sống của lập trình viên. CR là khẳng định cho đời sống của các hệ thống phần mềm. Có hoạt động, có giá trị nên các hệ thống mới có yêu cầu thay đổi cũng như yêu cầu chức năng mới. Và một lập trình viên lão luyện cần tính toán trước những khả năng.
Code hiện tại chỉ thêm một hàm private SaveResult kết nối trực tiếp đến DB. Các bạn chắc chắn đã nhận ra điểm yếu của giải pháp này và đã có trong đầu phác thảo cách để làm nó tốt hơn. Hàm private này, theo dụng ý của tôi, là chúng ta đã quay lại với bước đầu tien trong lập trình: viết một phiên bản chạy được. Chúng ta lại quay lại 01-runable, và tiếp tục một vòng lặp đến hết vòng đời sản phẩm. Vòng lặp này là không thể tránh khỏi. Mỗi dòng code chúng ta viết ra không chết cứng ở đó mà chúng ta sẽ còn quay lại với nó nhiều lần. Vì thế, bạn là một coder lão làng sẽ luôn biết cách làm cho cuộc sống dễ dàng hơn bằng cách nỗ lực làm những dòng code chỉn chu ngay từ những bước đầu tiên nhất.
Chúng ta sẽ tiếp tục refactor hàm SaveResult để BubbleSortCommand vẫn testable, cấu trúc chuwong trình vẫn mềm dẻo dễ mở rộng và độc lập, thậm chí có thể thay đổi sử dụng bất cứ database nào về sau mà không phá hỏng code sẵn có. Và lúc đó chúng ta có được một DESIGN tương đối hoàn thiện. Nó giải đáp câu hỏi của cậu em đồng nghiệp tôi lúc đầu: n-tiers thì nhận được lợi gì.
Các bạn thân mến, các design patterns, các mô hình lập trình không phải do ai phát minh ra, cũng ko phải những giải pháp có trước. Chúng được đúc kết từ kinh nghiệm của các lập trình viên qua hàng chục năm làm việc, và qua đó, các lập trình viên hiểu rằng khi áp dụng chúng, họ sẽ nhận được những giá trị mà tất cả chúng ta đều đồng ý rằng nó quan trọng cho phát triển phần mềm:
1. Khả năng bảo trì mã nguồn.
2. Khẳ năng tái sử dụng.
3. Khả năng mở rộng chức năng (extensibility).
4. Khả năng kiểm thử.
5. Khả năng mở rộng quy mô (scaling).
6. An toàn và bảo mật.
