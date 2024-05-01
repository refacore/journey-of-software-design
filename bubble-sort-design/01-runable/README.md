## Bối cảnh
Tôi nhận được yêu cầu viết một api sắp xếp một mảng số nguyên cho trước theo thuật toán nổi bọt.
Tôi tạo api project và test project. Tạo BubbleSortCommand. Tạo unit test. Test failed do command chưa được cài đặt thuật toán nổi bọt.
Tôi tìm tài liệu về thuật toán nổi bọt. Nhanh nhất là lên stackoverflow. Tôi kiếm được đoạn mã thực thi thuật toán nổi bọt bằng C#, copy nó về và paste vào class command tôi mới tạo.
Test passed và api của tôi được xây dựng xong.
## Đánh giá
Có thể phần lớn công việc của chúng ta sẽ tương tự như thế. Phần code hiện tại cũng không tệ. Logic thực thi được đóng gói vào class command giúp cho việc đọc code dễ dàng hơn, cũng như dễ bảo trì hơn. Code cũng đã được unit test đảm bảo.
Nhưng tôi mong rằng chúng ta sẽ không chỉ dừng ở bước này coi như đã hoàn thành công việc.
