## Bối cảnh
Phần code ở bước thứ 3 cần tạo endpoint mới cho mỗi kiểu dữ liệu được thêm vào sau này. Tôi muốn chương trình chỉ dùng một endpoint duy nhất mà thôi.
Tôi lựa chọn đóng gói logic sắp xếp ra một nhóm mới, tạo một factory thực hiện việc khởi tạo mỗi lớp thực thi riêng biệt theo lựa chọn DataType mà client gửi lên.
## Đánh giá
Với phương án này, tôi bỏ ưu thế strong type để đổi lấy việc có một endpoint duy nhất. Nhưng nó cũng không thật sự toàn mỹ khi client vẫn phải gửi DataType thay cho việc đổi endpoint.
Hãy chú ý tới Unit tests. Số lượng UTs tăng lên do số class được tạo thêm, cùng với việc dùng mocking để cô lập các class. Việc mocking cũng đảm bảo một phần rằng class sẽ hoạt động như chúng ta mong muốn (gọi đúng mock object chúng ta truyền vào).
Giải pháp này thực sự không tốt hơn giải pháp cũ khi abstraction tăng cũng như khối lượng công việc tăng (unit tests).
