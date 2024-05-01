## Bối cảnh
Lần refactor trước không thực sự thành công vì những ưu điểm nó mang lại không bù được những nhược điểm. Chúng ta cần phải refactor thêm một lần nữa hoặc giữ nguyên giải pháp trước đó nữa. Nhưng giải pháp trước đó nữa không thự sự thỏa mãn.
Lần này, phần logic được đóng gói không phải là toàn bộ thuật toán nổi bọt. Sự khác nhau của các kiểu dữ liệu khác nhau chỉ là cách so sánh. Vì thế, chỉ phần so sánh sẽ được đói gói ra các Comparer khác nhau cho từng kiểu dữ liệu khác nhau.
Để giữ ưu thế strong type, các endpoint khác nhau cho kiểu dữ liệu khác nhau sẽ vẫn được sử dụng.
## Đánh giá
Nhược điểm nhiều endpoint và khối lượng công việc tăng lên không được khắc phục.
Bù lại, code chặt chẽ hơn. Phần logic của thuật toán nổi bọt được bảo toàn và đảm bảo các implementation về sau không cần copy paste hay sửa đổi nó. Chỉ phần logic so sánh khác nhau đối với kiểu dữ liệu khác nhau là phải viết lại. Giải pháp này tăng tính tái sử dụng của code cũng như khả năng bảo trì code về sau.
Bạn hãy đánh giá Level of Abstraction (Over Design).
