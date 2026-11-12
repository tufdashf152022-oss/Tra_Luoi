using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tra_Luoi.Models;
namespace Tra_Luoi.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult Employees(int id)
        {
            List<Employees> dsTuyenDung = new List<Employees>()
            {
                new Employees
                {
                    MaTD = 1,
                    ViTri = "Compensation & Benefits Specialist (C&B)",
                    DiaDiem = "TP. Hồ Chí Minh",
                    MucLuong = "14.000.000 – 18.000.000 VNĐ/tháng",
                    HinhThuc = "Toàn thời gian",
                    KinhNghiem = "Từ 2 năm trong lĩnh vực C&B hoặc nhân sự",
                    HanNop = "31/12/2026",

                    MoTaCongViec = new List<string>
                    {
                        "Phụ trách công tác tính lương hằng tháng cho nhân viên văn phòng và đội ngũ nhân sự tại hệ thống cửa hàng Trà Lười.",
                        "Kiểm tra, tổng hợp dữ liệu chấm công, ngày nghỉ, tăng ca, phụ cấp và các khoản khấu trừ để đảm bảo bảng lương chính xác.",
                        "Quản lý và thực hiện các thủ tục liên quan đến bảo hiểm xã hội, bảo hiểm y tế, bảo hiểm thất nghiệp theo quy định.",
                        "Thực hiện các thủ tục đăng ký mã số thuế, đăng ký người phụ thuộc và hỗ trợ quyết toán thuế thu nhập cá nhân cho nhân viên.",
                        "Xây dựng, cập nhật và triển khai các chính sách lương, thưởng, phụ cấp và phúc lợi phù hợp với từng nhóm vị trí.",
                        "Theo dõi chi phí nhân sự, lập báo cáo quỹ lương và phân tích biến động chi phí lao động theo tháng.",
                        "Giải đáp thắc mắc của nhân viên về tiền lương, chế độ bảo hiểm, nghỉ phép và các quyền lợi liên quan.",
                        "Phối hợp với bộ phận tuyển dụng và quản lý cửa hàng để cập nhật thông tin nhân sự, hợp đồng lao động và biến động nhân sự.",
                        "Kiểm tra, lưu trữ hồ sơ nhân sự và đảm bảo tính bảo mật của thông tin tiền lương.",
                        "Cập nhật các quy định pháp luật về lao động, tiền lương, bảo hiểm và thuế để tham mưu cho bộ phận quản lý."
                    },

                    YeuCau = new List<string>
                    {
                        "Tốt nghiệp Cao đẳng hoặc Đại học chuyên ngành Quản trị nhân lực, Kế toán, Tài chính hoặc các ngành liên quan.",
                        "Có ít nhất 2 năm kinh nghiệm trong lĩnh vực C&B hoặc quản lý tiền lương và phúc lợi.",
                        "Nắm vững kiến thức về luật lao động, bảo hiểm xã hội, bảo hiểm y tế và thuế thu nhập cá nhân.",
                        "Có kinh nghiệm tính lương cho số lượng nhân sự lớn, ưu tiên ứng viên từng làm việc tại chuỗi bán lẻ, nhà hàng hoặc doanh nghiệp F&B.",
                        "Sử dụng thành thạo Excel và có khả năng làm việc với phần mềm quản lý nhân sự, chấm công và tính lương.",
                        "Có khả năng tổng hợp, phân tích dữ liệu và lập báo cáo nhân sự chính xác.",
                        "Cẩn thận, trung thực, có tinh thần trách nhiệm và ý thức bảo mật thông tin.",
                        "Có kỹ năng giao tiếp, giải quyết vấn đề và phối hợp với các phòng ban.",
                        "Chủ động cập nhật các quy định mới liên quan đến chính sách lao động và phúc lợi."
                    },

                    QuyenLoi = new List<string>
                    {
                        "Mức lương từ 14–18 triệu đồng/tháng, thỏa thuận theo năng lực và kinh nghiệm.",
                        "Được xem xét thưởng theo hiệu quả công việc và kết quả hoạt động kinh doanh của công ty.",
                        "Được tham gia xây dựng và cải tiến hệ thống lương thưởng, phúc lợi cho toàn bộ nhân sự Trà Lười.",
                        "Được cung cấp đầy đủ công cụ và phần mềm hỗ trợ công việc.",
                        "Hưởng các chế độ bảo hiểm, nghỉ phép, lễ và Tết theo quy định pháp luật khi đáp ứng điều kiện tham gia.",
                        "Được tham gia các chương trình đào tạo nâng cao chuyên môn về quản trị nhân sự và chính sách đãi ngộ.",
                        "Có cơ hội phát triển lên vị trí C&B Supervisor hoặc HR Manager.",
                        "Môi trường làm việc chuyên nghiệp, ổn định và có cơ hội gắn bó lâu dài."
                    },

                    ThoiGianLamViec = new List<string>
                    {
                        "Thứ 2 – Thứ 6: 08:30 – 17:30.",
                        "Nghỉ trưa: 12:00 – 13:00.",
                        "Thứ 7, Chủ nhật: Nghỉ theo lịch làm việc của công ty.",
                        "Có thể phát sinh thời gian xử lý bảng lương và báo cáo vào các kỳ chốt lương hằng tháng."
                    },

                    DiaDiemChiTiet = "Văn phòng điều hành Trà Lười tại TP. Hồ Chí Minh. Ứng viên làm việc trực tiếp với bộ phận Nhân sự và phối hợp với quản lý các cửa hàng trong hệ thống.",
                    CachThucUngTuyen = "Ứng viên quan tâm vui lòng gửi CV kèm thông tin kinh nghiệm C&B, quy mô nhân sự từng phụ trách và mức lương mong muốn về bộ phận tuyển dụng của Trà Lười.",
                    TieuDeEmail = "[C&B SPECIALIST] – HỌ VÀ TÊN",
                    LoiMoi = "Hãy gia nhập Trà Lười để cùng xây dựng môi trường làm việc chuyên nghiệp và công bằng!",
                    Email = "tuyendung@traluoi.com"
                },
                new Employees
                {
                   MaTD = 2,
                    ViTri = "Category Procurement Officer (Capex, MRO) – For Store",
                    DiaDiem = "TP. Hồ Chí Minh",
                    MucLuong = "14.000.000 – 18.000.000 VNĐ/tháng",
                    HinhThuc = "Toàn thời gian",
                    KinhNghiem = "Từ 1–2 năm trong lĩnh vực thu mua, cung ứng hoặc mua sắm",
                    HanNop = "9/9/2026",

                    MoTaCongViec = new List<string>
                    {
                        "Phụ trách hoạt động thu mua thiết bị đầu tư (Capex) phục vụ việc mở mới, nâng cấp và vận hành hệ thống cửa hàng Trà Lười.",
                        "Tìm kiếm, đánh giá và lựa chọn nhà cung cấp máy pha chế, máy làm đá, tủ lạnh, quầy bar, thiết bị bảo quản và các công cụ phục vụ cửa hàng.",
                        "Quản lý danh mục vật tư bảo trì, sửa chữa (MRO) như linh kiện máy móc, thiết bị điện, hệ thống nước và vật tư thay thế.    ",
                        "Tiếp nhận yêu cầu mua sắm từ bộ phận vận hành cửa hàng, kiểm tra nhu cầu và đề xuất phương án cung ứng phù hợp.",
                        "Thu thập báo giá, so sánh chất lượng, chi phí và thời gian giao hàng để lựa chọn nhà cung cấp tối ưu.",
                        "Đàm phán giá cả, điều khoản thanh toán, chính sách bảo hành và các điều kiện hợp đồng với đối tác..",
                        "Theo dõi tiến độ đặt hàng, giao nhận và lắp đặt thiết bị, đảm bảo đáp ứng đúng kế hoạch hoạt động của cửa hàng.",
                        "Kiểm soát ngân sách mua sắm, theo dõi chi phí và đề xuất giải pháp tiết kiệm nhưng vẫn đảm bảo chất lượng.",
                        "Phối hợp với bộ phận kỹ thuật, kho và vận hành để xử lý các vấn đề liên quan đến thiết bị hư hỏng, bảo trì hoặc thay thế.",
                        "Lập báo cáo định kỳ về tình hình mua sắm, hiệu quả nhà cung cấp và chi phí theo từng danh mục hàng hóa."
                    },

                    YeuCau = new List<string>
                    {
                        "Tốt nghiệp Cao đẳng hoặc Đại học chuyên ngành Quản trị kinh doanh, Logistics, Kinh tế, Chuỗi cung ứng hoặc các ngành liên quan.",
                        "Có từ 1–2 năm kinh nghiệm trong lĩnh vực thu mua, procurement hoặc quản lý nhà cung cấp.",
                        "Ưu tiên ứng viên từng mua sắm thiết bị, máy móc, vật tư bảo trì cho chuỗi cửa hàng, nhà hàng hoặc lĩnh vực bán lẻ.",
                        "Hiểu biết cơ bản về quy trình mua hàng, báo giá, hợp đồng và quản lý chi phí.",
                        "Có kỹ năng đàm phán, giao tiếp và xây dựng mối quan hệ với nhà cung cấp.",
                        "Sử dụng tốt Excel và các công cụ văn phòng để theo dõi đơn hàng, ngân sách và dữ liệu mua sắm.",
                        "Có khả năng phân tích, so sánh báo giá và đánh giá chất lượng sản phẩm, dịch vụ.",
                        "Trung thực, cẩn thận, chủ động và có trách nhiệm trong công việc.",
                        "Có khả năng phối hợp với nhiều bộ phận và xử lý các yêu cầu mua sắm phát sinh."
                    },

                    QuyenLoi = new List<string>
                    {
                        "Mức lương từ 14–18 triệu đồng/tháng, thỏa thuận theo năng lực và kinh nghiệm.",
                        "Thưởng theo hiệu quả công việc và kết quả tiết kiệm chi phí mua sắm.",
                        "Được tham gia xây dựng hệ thống nhà cung cấp và quy trình mua sắm cho chuỗi cửa hàng Trà Lười.",
                        "Có cơ hội tiếp xúc với nhiều nhóm thiết bị, máy móc và vật tư phục vụ hoạt động kinh doanh F&B.",
                        "Được cung cấp trang thiết bị và công cụ cần thiết để hoàn thành công việc.",
                        "Hưởng các chế độ bảo hiểm, nghỉ phép, lễ và Tết theo quy định pháp luật khi đáp ứng điều kiện tham gia.",
                        "Được đào tạo và nâng cao kỹ năng chuyên môn về quản lý thu mua, đàm phán và quản trị nhà cung cấp.",
                        "Có cơ hội phát triển lên vị trí Senior Procurement Officer hoặc Procurement Supervisor.",
                        "Môi trường làm việc chuyên nghiệp, năng động và có cơ hội gắn bó lâu dài."
                    },

                    ThoiGianLamViec = new List<string>
                    {
                        "Thứ 2 – Thứ 6: 08:30 – 17:30.",
                        "Nghỉ trưa: 12:00 – 13:00.",
                        "Thứ 7, Chủ nhật: Nghỉ theo lịch làm việc của công ty.",
                        "Có thể đi khảo sát cửa hàng hoặc làm việc với nhà cung cấp khi cần thiết.\r\n"
                    },

                    DiaDiemChiTiet = "Văn phòng điều hành Trà Lười tại TP. Hồ Chí Minh. Có thể di chuyển đến các cửa hàng và địa điểm nhà cung cấp để kiểm tra thiết bị, vật tư khi phát sinh yêu cầu.",
                    CachThucUngTuyen = "Ứng viên quan tâm vui lòng gửi CV kèm thông tin kinh nghiệm thu mua, các danh mục hàng hóa từng phụ trách và mức lương mong muốn về bộ phận tuyển dụng của Trà Lười.",
                    TieuDeEmail = "Tiêu đề email: [CATEGORY PROCUREMENT OFFICER] – HỌ VÀ TÊN",
                    LoiMoi = "Bạn có kinh nghiệm trong lĩnh vực thu mua và quản lý nhà cung cấp?\r\nGia nhập Trà Lười để cùng xây dựng hệ thống cửa hàng vận hành hiệu quả!",
                    Email = "tuyendung@traluoi.com"
                },
                new Employees
                {
                    MaTD = 3,
                    ViTri = "Giám sát cửa hàng",
                    DiaDiem = "Hà Nam",
                    MucLuong = "12.000.000 – 16.000.000 VNĐ/tháng",
                    HinhThuc = "Toàn thời gian",
                    KinhNghiem = "Từ 1–2 năm ở vị trí giám sát hoặc quản lý cửa hàng F&B",
                    HanNop = "31/8/2026",
                    MoTaCongViec = new List<string>
                    {
                        "Chịu trách nhiệm giám sát toàn bộ hoạt động kinh doanh và vận hành hằng ngày tại cửa hàng Trà Lười.",
                        "Phân công công việc, sắp xếp lịch làm việc và theo dõi hiệu suất của nhân viên trong từng ca.",
                        "Kiểm tra chất lượng đồ uống, quy trình pha chế và thái độ phục vụ khách hàng nhằm đảm bảo tiêu chuẩn thương hiệu.",
                        "Theo dõi doanh thu, số lượng đơn hàng và tình hình kinh doanh, đề xuất giải pháp cải thiện kết quả bán hàng.",
                        "Kiểm soát hàng tồn kho, nguyên liệu pha chế, hạn sử dụng và thực hiện đặt hàng bổ sung khi cần thiết.",
                        "Giám sát việc thu ngân, quản lý tiền mặt và đối soát doanh thu cuối mỗi ca làm việc.",
                        "Tiếp nhận và xử lý các phản hồi, khiếu nại của khách hàng; đảm bảo trải nghiệm dịch vụ tích cực.",
                        "Kiểm tra vệ sinh khu vực pha chế, quầy phục vụ, kho hàng và không gian cửa hàng.",
                        "Hướng dẫn, đào tạo nhân viên mới về quy trình phục vụ, kỹ năng bán hàng và tiêu chuẩn vận hành.",
                        "Tổng hợp báo cáo doanh thu, nhân sự, hàng hóa và các vấn đề phát sinh cho quản lý khu vực."
                                            },
                    YeuCau = new List<string>
                    {
                        "Tốt nghiệp THPT trở lên, ưu tiên ứng viên có trình độ Cao đẳng hoặc Đại học chuyên ngành Quản trị kinh doanh, Nhà hàng – Khách sạn hoặc các ngành liên quan.",
                        "Có ít nhất 1–2 năm kinh nghiệm trong lĩnh vực F&B, ưu tiên từng làm cửa hàng trưởng hoặc giám sát cửa hàng.",
                        "Có kỹ năng quản lý, phân công công việc và đào tạo nhân viên.",
                        "Hiểu biết về quy trình vận hành cửa hàng, quản lý kho và kiểm soát doanh thu.",
                        "Có khả năng xử lý tình huống, giải quyết khiếu nại và chăm sóc khách hàng.",
                        "Sử dụng được các công cụ văn phòng và phần mềm bán hàng, quản lý đơn hàng.",
                        "Trung thực, trách nhiệm, chủ động và có khả năng chịu áp lực công việc.",
                        "Có kỹ năng giao tiếp, phối hợp nhóm và tổ chức công việc hiệu quả.",
                        "Sẵn sàng làm việc theo ca, cuối tuần và ngày lễ theo lịch phân công."
                    },
                    QuyenLoi = new List<string>
                    {
                        "Mức lương từ 12–16 triệu đồng/tháng, thỏa thuận theo năng lực và kinh nghiệm.",
                        "Thưởng doanh thu cửa hàng và thưởng theo hiệu quả quản lý, vận hành.",
                        "Được đào tạo chuyên sâu về quản lý cửa hàng, kiểm soát chi phí và phát triển đội ngũ nhân viên.",
                        "Được cung cấp đồng phục, công cụ và thiết bị cần thiết phục vụ công việc.",
                        "Hưởng các chế độ bảo hiểm, nghỉ phép, lễ và Tết theo quy định pháp luật khi đáp ứng điều kiện tham gia.",
                        "Có cơ hội tham gia các chương trình phát triển nhân sự và mở rộng hệ thống cửa hàng.",
                        "Cơ hội thăng tiến lên vị trí Quản lý khu vực hoặc các vị trí quản lý vận hành cấp cao.",
                        "Môi trường làm việc năng động, chuyên nghiệp và có cơ hội gắn bó lâu dài."
                    },
                      ThoiGianLamViec = new List<string>
                    {
                        "Làm việc theo ca, 8 tiếng/ngày.",
                        "Ca sáng: 07:00 – 15:00.",
                        "Ca chiều: 14:00 – 22:00.",
                        "Lịch làm việc được sắp xếp luân phiên theo tình hình hoạt động của cửa hàng.",
                        "Nghỉ theo lịch phân công và quy định của công ty."
                    },

                    DiaDiemChiTiet = "Hệ thống cửa hàng Trà Lười tại khu vực Hà Nam. Địa điểm cửa hàng cụ thể sẽ được thông báo trong quá trình phỏng vấn.",
                    CachThucUngTuyen = "Ứng viên quan tâm vui lòng gửi CV kèm thông tin kinh nghiệm quản lý cửa hàng, quy mô nhân sự từng phụ trách và mức lương mong muốn về bộ phận tuyển dụng của Trà Lười.",
                    TieuDeEmail = "Tiêu đề email: [GIÁM SÁT CỬA HÀNG – HÀ NAM] – HỌ VÀ TÊN",
                    LoiMoi = "Bạn có khả năng quản lý và điều hành hoạt động cửa hàng?\r\nGia nhập Trà Lười để cùng phát triển đội ngũ và nâng cao chất lượng dịch vụ!",
                    Email = "tuyendung@traluoi.com"
                },
                new Employees
                {
                    MaTD = 4,
                    ViTri = "Giám sát cửa hàng",
                    DiaDiem = "Nam Định",
                    MucLuong = "11.000.000 – 15.000.000 VNĐ/tháng",
                    HinhThuc = "Toàn thời gian",
                    KinhNghiem = "Từ 1–2 năm ở vị trí giám sát hoặc quản lý cửa hàng F&B",
                    HanNop = "31/8/2026",
                    MoTaCongViec = new List<string>
                    {
                        "Quản lý và giám sát hoạt động kinh doanh hằng ngày tại cửa hàng, đảm bảo các quy trình vận hành được thực hiện đúng tiêu chuẩn của Trà Lười.",
                        "Lập kế hoạch làm việc, phân bổ nhân sự theo từng ca và kiểm soát tình hình chấm công, đi làm của nhân viên.",
                        "Theo dõi doanh thu, số lượng đơn hàng và hiệu quả bán hàng; đề xuất các chương trình thúc đẩy doanh số phù hợp với thị trường địa phương.",
                        "Kiểm tra chất lượng nguyên liệu, quy trình pha chế và thành phẩm trước khi phục vụ khách hàng.",
                        "Kiểm soát hàng tồn kho, định mức sử dụng nguyên liệu và hạn sử dụng để hạn chế thất thoát, lãng phí.",
                        "Đánh giá hiệu suất làm việc của nhân viên, tổ chức hướng dẫn và đào tạo nghiệp vụ phục vụ, bán hàng và pha chế.",
                        "Tiếp nhận, giải quyết phản hồi của khách hàng và xử lý các tình huống phát sinh trong quá trình vận hành.",
                        "Kiểm tra việc vệ sinh, bảo quản thiết bị, cơ sở vật chất và không gian phục vụ tại cửa hàng.",
                        "Thực hiện kiểm kê định kỳ, đối soát doanh thu và kiểm tra các khoản chi phí phát sinh.",
                        "Tổng hợp báo cáo kinh doanh, nhân sự và tình hình vận hành, đề xuất giải pháp cải thiện hiệu quả cửa hàng cho quản lý khu vực."
                                            },
                    YeuCau = new List<string>
                    {
                        "Tốt nghiệp THPT trở lên, ưu tiên ứng viên có trình độ Cao đẳng hoặc Đại học chuyên ngành Quản trị kinh doanh, Nhà hàng – Khách sạn hoặc các ngành liên quan.",
                        "Có ít nhất 1–2 năm kinh nghiệm trong lĩnh vực F&B, ưu tiên từng làm cửa hàng trưởng hoặc giám sát cửa hàng.",
                        "Có kỹ năng quản lý, phân công công việc và đào tạo nhân viên.",
                        "Hiểu biết về quy trình vận hành cửa hàng, quản lý kho và kiểm soát doanh thu.",
                        "Có khả năng xử lý tình huống, giải quyết khiếu nại và chăm sóc khách hàng.",
                        "Sử dụng được các công cụ văn phòng và phần mềm bán hàng, quản lý đơn hàng.",
                        "Trung thực, trách nhiệm, chủ động và có khả năng chịu áp lực công việc.",
                        "Có kỹ năng giao tiếp, phối hợp nhóm và tổ chức công việc hiệu quả.",
                        "Sẵn sàng làm việc theo ca, cuối tuần và ngày lễ theo lịch phân công."
                    },
                    QuyenLoi = new List<string>
                    {
                        "Mức lương từ 11–15 triệu đồng/tháng, thỏa thuận theo năng lực và kinh nghiệm.",
                        "Thưởng doanh thu cửa hàng và thưởng theo hiệu quả quản lý, vận hành.",
                        "Được đào tạo chuyên sâu về quản lý cửa hàng, kiểm soát chi phí và phát triển đội ngũ nhân viên.",
                        "Được cung cấp đồng phục, công cụ và thiết bị cần thiết phục vụ công việc.",
                        "Hưởng các chế độ bảo hiểm, nghỉ phép, lễ và Tết theo quy định pháp luật khi đáp ứng điều kiện tham gia.",
                        "Có cơ hội tham gia các chương trình phát triển nhân sự và mở rộng hệ thống cửa hàng.",
                        "Cơ hội thăng tiến lên vị trí Quản lý khu vực hoặc các vị trí quản lý vận hành cấp cao.",
                        "Môi trường làm việc năng động, chuyên nghiệp và có cơ hội gắn bó lâu dài."
                    },
                      ThoiGianLamViec = new List<string>
                    {
                        "Làm việc theo ca, 8 tiếng/ngày.",
                        "Ca sáng: 07:00 – 15:00.",
                        "Ca chiều: 14:00 – 22:00.",
                        "Lịch làm việc được sắp xếp luân phiên theo tình hình hoạt động của cửa hàng.",
                        "Nghỉ theo lịch phân công và quy định của công ty."
                    },

                    DiaDiemChiTiet = "Hệ thống cửa hàng Trà Lười tại khu vực Nam Định. Địa điểm cửa hàng cụ thể sẽ được thông báo trong quá trình phỏng vấn.",
                    CachThucUngTuyen = "Ứng viên quan tâm vui lòng gửi CV kèm thông tin kinh nghiệm quản lý cửa hàng, quy mô nhân sự từng phụ trách và mức lương mong muốn về bộ phận tuyển dụng của Trà Lười.",
                    TieuDeEmail = "Tiêu đề email: [GIÁM SÁT CỬA HÀNG – NAM ĐỊNH] – HỌ VÀ TÊN",
                    LoiMoi = "Bạn có khả năng quản lý và điều hành hoạt động cửa hàng?\r\nGia nhập Trà Lười để cùng phát triển đội ngũ và nâng cao chất lượng dịch vụ!",
                    Email = "tuyendung@traluoi.com"
                },
                new Employees
                {
                    MaTD = 5,
                    ViTri = "HRBP Intern",
                    DiaDiem = "Long An",
                    MucLuong = "9.000.000 - 10.000.000 VNĐ/tháng",
                    HinhThuc = "Thực tập toàn thời gian",
                    KinhNghiem = "Không yêu cầu",
                    HanNop = "30/9/2026",
                    MoTaCongViec = new List<string>
                    {
                       "Hỗ trợ HRBP trong việc triển khai các hoạt động quản trị nhân sự tại văn phòng, kho và hệ thống cửa hàng Trà Lười.",
                        "Phối hợp với các bộ phận để thu thập nhu cầu tuyển dụng, tổng hợp thông tin vị trí cần tuyển và cập nhật tình hình nhân sự.",
                        "Hỗ trợ đăng tin tuyển dụng, sàng lọc hồ sơ, liên hệ ứng viên và sắp xếp lịch phỏng vấn.",
                        "Tham gia chuẩn bị hồ sơ tiếp nhận nhân viên mới, hướng dẫn các thủ tục nhận việc và theo dõi quá trình hội nhập.",
                        "Cập nhật, lưu trữ hồ sơ nhân viên, hợp đồng lao động và các thông tin nhân sự theo quy định.",
                        "Hỗ trợ theo dõi tình hình chấm công, nghỉ phép, biến động nhân sự và tổng hợp dữ liệu định kỳ.",
                        "Phối hợp tổ chức các chương trình đào tạo nội bộ, hoạt động gắn kết nhân viên và truyền thông chính sách nhân sự.",
                        "Tiếp nhận các phản hồi, khó khăn từ nhân viên và hỗ trợ HRBP chuyển thông tin đến bộ phận phụ trách.",
                        "Thực hiện báo cáo nhân sự, cập nhật các biểu mẫu và hỗ trợ những công việc hành chính khác theo phân công."
                    },
                    YeuCau = new List<string>
                    {
                        "Tốt nghiệp THPT trở lên, ưu tiên ứng viên có trình độ Trung cấp hoặc Cao đẳng chuyên ngành Pha chế, Nhà hàng – Khách sạn hoặc các ngành liên quan.",
                        "Có từ 6 tháng – 1 năm kinh nghiệm trong lĩnh vực pha chế đồ uống, ưu tiên từng làm việc tại cửa hàng F&B.",
                        "Hiểu biết về các loại nguyên liệu, công thức pha chế và quy trình phục vụ đồ uống.",
                        "Có kỹ năng làm việc nhóm, phối hợp với nhân viên phục vụ và quản lý cửa hàng.",
                        "Trung thực, cẩn thận, chủ động và có trách nhiệm trong công việc.",
                        "Có khả năng chịu áp lực công việc và làm việc theo ca, cuối tuần và ngày lễ.",
                        "Sẵn sàng học hỏi và nâng cao kỹ năng pha chế theo tiêu chuẩn của Trà Lười."
                    },
                    QuyenLoi = new List<string>
                    {
                        "Thu nhập hỗ trợ từ 9.000.000 - 10.000.000 VNĐ/tháng, tùy theo năng lực và thời gian làm việc.",
                        "Được hướng dẫn trực tiếp bởi đội ngũ nhân sự có kinh nghiệm trong hoạt động quản trị nhân sự doanh nghiệp.",
                        "Có cơ hội tiếp cận quy trình HRBP thực tế tại môi trường bán lẻ và F&B.",
                        "Được tham gia các hoạt động tuyển dụng, đào tạo, quản lý hiệu suất và phát triển nhân sự.",
                        "Được đào tạo kỹ năng phỏng vấn, giao tiếp nội bộ, xử lý dữ liệu và lập báo cáo nhân sự.",
                        "Được tham gia các chương trình đào tạo, hoạt động nội bộ và sự kiện của công ty.",
                        "Có cơ hội được xem xét trở thành nhân viên chính thức sau thời gian thực tập nếu đáp ứng yêu cầu công việc.",
                        "Được xác nhận thực tập và hỗ trợ các giấy tờ liên quan theo quy định của công ty."
                    },
                      ThoiGianLamViec = new List<string>
                    {
                       "Thứ 2 - Thứ 6 và sáng Thứ 7.",
                        "Thời gian: 08:00 - 17:00.",
                        "Nghỉ trưa theo quy định của công ty.",
                        "Ưu tiên ứng viên có thể làm việc toàn thời gian và cam kết thực tập tối thiểu 3 tháng."
                    },
                      DiaDiemChiTiet = "Văn phòng và khu vực vận hành nhân sự của Trà Lười tại Long An. Địa chỉ làm việc cụ thể sẽ được thông báo trong quá trình phỏng vấn.",
                      CachThucUngTuyen = "Ứng viên gửi CV cá nhân, trong đó nêu rõ chuyên ngành học, kinh nghiệm hoạt động và định hướng phát triển trong lĩnh vực nhân sự.",
                        TieuDeEmail = " [LONG AN] - HRBP INTERN - HỌ VÀ TÊN",
                        LoiMoi = "CV cá nhân và thông tin liên hệ.",
                        Email = "tuyendung@traluoi.com"
                },
                new Employees                 {
                    MaTD = 6,
                    ViTri = " Nhân viên Full-time",
                    DiaDiem = "Hà Nội",
                    MucLuong = "9.000.000 - 12.000.000 VNĐ/tháng",
                    HinhThuc = "Toàn thời gian",
                    KinhNghiem = "Không yêu cầu, ưu tiên ứng viên có kinh nghiệm bán hàng hoặc dịch vụ khách hàng",
                    HanNop = "30/12/2026",
                    MoTaCongViec = new List<string>
                    {
                        "Tiếp đón, tư vấn và giới thiệu các loại trà, cà phê và đồ uống đến khách hàng.",
                        "Tiếp nhận đơn hàng trực tiếp tại cửa hàng và thông qua các nền tảng đặt đồ uống trực tuyến.",
                        "Thực hiện pha chế các loại đồ uống theo công thức và tiêu chuẩn của cửa hàng.",
                        "Chuẩn bị nguyên liệu, topping và các vật dụng cần thiết trước mỗi ca làm việc.",
                        "Kiểm tra chất lượng đồ uống trước khi giao cho khách hàng.",
                        "Thực hiện thanh toán, kiểm tra hóa đơn và quản lý tiền trong ca làm việc.",
                        "Vệ sinh quầy pha chế, dụng cụ và khu vực phục vụ khách hàng.",
                        "Kiểm tra số lượng nguyên liệu, báo cáo tình trạng hàng hóa và hỗ trợ kiểm kê định kỳ."
                    },
                    YeuCau = new List<string>
                    {
                        "Nam/Nữ từ 18 tuổi trở lên, có sức khỏe tốt.",
                        "Tốt nghiệp THPT trở lên.",
                        "Ưu tiên ứng viên có kinh nghiệm bán hàng, phục vụ hoặc pha chế đồ uống.",
                        "Giao tiếp thân thiện, vui vẻ và có khả năng tư vấn khách hàng.",
                        "Có tinh thần trách nhiệm, trung thực và chăm chỉ.",
                        "Có khả năng làm việc nhóm và xử lý tình huống trong giờ cao điểm.",
                        "Sẵn sàng làm việc theo lịch phân ca của cửa hàng."
                    },
                    QuyenLoi = new List<string>
                    {
                        "Mức lương từ 9 - 12 triệu đồng/tháng tùy theo năng lực và kinh nghiệm.",
                        "Được đào tạo kỹ năng pha chế và quy trình phục vụ khách hàng.",
                        "Được thưởng doanh số và thưởng theo hiệu quả công việc.",
                        "Hỗ trợ phụ cấp ăn uống và các khoản phụ cấp theo chính sách cửa hàng.",
                        "Được hưởng chế độ nghỉ phép, nghỉ lễ theo quy định.",
                        "Có cơ hội phát triển lên vị trí trưởng ca hoặc quản lý cửa hàng.",
                        "Môi trường làm việc trẻ trung, năng động và thân thiện."
                    },
                      ThoiGianLamViec = new List<string>
                    {
                       "Làm việc theo ca 8 tiếng/ngày.",
                        "Ca sáng: 07:00 - 15:00.",
                        "Ca chiều: 14:00 - 22:00.",
                        "Lịch làm việc được sắp xếp theo nhu cầu hoạt động của cửa hàng."
                    },
                      DiaDiemChiTiet = "Các cửa hàng Trà Lười tại khu vực Hà Đông, Thành phố Hà Nội.",
                      CachThucUngTuyen = "CV giới thiệu bản thân và kinh nghiệm làm việc (nếu có).\r\nThông tin liên hệ và thời gian có thể bắt đầu làm việc.\r\nTrao đổi trực tiếp trong buổi phỏng vấn.",
                        TieuDeEmail = " [HÀ NỘI] - FULLTIME - HỌ VÀ TÊN",
                        LoiMoi = "Bạn có kinh nghiệm và mong muốn phát triển trong lĩnh vực kho vận? Hãy gia nhập đội ngũ Trà Lười ngay hôm nay!",
                        Email = "tuyendung@traluoi.com"
                },
                new Employees
                {
                    MaTD = 7,
                    ViTri = "R&D Intern",
                    DiaDiem = "TP. Hồ Chí Minh",
                    MucLuong = "9.000.000 – 12.000.000 VNĐ/tháng",
                    HinhThuc = "Thực tập toàn thời gian",
                    KinhNghiem = "Không yêu cầu, ưu tiên ứng viên có kiến thức về thực phẩm và đồ uống",
                    HanNop = "10/9/2026",
                    MoTaCongViec = new List<string>
                    {
                        "Hỗ trợ nghiên cứu, phát triển các sản phẩm đồ uống mới như trà sữa, trà trái cây, cà phê, nước ép và các dòng thức uống theo mùa.",
                        "Tìm hiểu, đánh giá đặc tính của nguyên liệu pha chế như các loại trà, sữa, syrup, bột nền, trái cây và topping.",
                        "Tham gia thử nghiệm công thức mới, điều chỉnh tỷ lệ nguyên liệu, định lượng và phương pháp pha chế để tạo ra hương vị phù hợp.",
                        "Chuẩn bị mẫu thử và tổ chức đánh giá cảm quan về màu sắc, mùi hương, độ ngọt, độ béo, kết cấu và chất lượng sản phẩm.",
                        "Ghi nhận kết quả thử nghiệm, so sánh các phiên bản công thức và đề xuất phương án cải tiến sản phẩm.",
                        "Hỗ trợ kiểm tra độ ổn định của sản phẩm trong quá trình bảo quản, theo dõi sự thay đổi về chất lượng và hương vị.",
                        "Phối hợp với bộ phận vận hành cửa hàng để thử nghiệm công thức thực tế, đánh giá khả năng pha chế và tính đồng nhất của sản phẩm.",
                        "Cập nhật tài liệu công thức, định lượng nguyên liệu, quy trình pha chế và báo cáo tiến độ các dự án R&D."
                    },
                    YeuCau = new List<string>
                    {
                        "Sinh viên năm cuối hoặc mới tốt nghiệp Cao đẳng, Đại học các chuyên ngành Công nghệ thực phẩm, Hóa thực phẩm, Công nghệ sinh học hoặc ngành liên quan.",
                        "Có niềm yêu thích với lĩnh vực đồ uống, nghiên cứu công thức và phát triển sản phẩm F&B.",
                        "Có kiến thức cơ bản về nguyên liệu thực phẩm, quy trình chế biến và nguyên tắc vệ sinh an toàn thực phẩm.",
                        "Cẩn thận, tỉ mỉ trong quá trình cân đo nguyên liệu, pha chế mẫu và ghi nhận kết quả thử nghiệm.",
                        "Có khả năng quan sát, cảm nhận hương vị và đánh giá chất lượng sản phẩm.",
                        "Sử dụng cơ bản Microsoft Word, Excel và PowerPoint để tổng hợp dữ liệu, lập báo cáo.",
                        "Chủ động học hỏi, có tư duy sáng tạo và khả năng làm việc nhóm tốt.",
                        "Có thể tham gia thực tập tối thiểu 3–6 tháng theo lịch làm việc của công ty."
                    },
                    QuyenLoi = new List<string>
                    {
                        "Hỗ trợ thực tập từ 9–12 triệu đồng/tháng tùy theo năng lực và thời gian làm việc.",
                        "Được hướng dẫn trực tiếp bởi đội ngũ nghiên cứu và phát triển sản phẩm có kinh nghiệm trong ngành F&B.",
                        "Được tham gia thực tế vào quy trình phát triển sản phẩm, từ nghiên cứu nguyên liệu, thử nghiệm công thức đến đánh giá và hoàn thiện sản phẩm.",
                        "Có cơ hội đóng góp ý tưởng và trực tiếp tham gia phát triển các món đồ uống mới cho thương hiệu Trà Lười.",
                        "Được cung cấp nguyên liệu, dụng cụ và thiết bị cần thiết phục vụ quá trình thử nghiệm.",
                        "Được hỗ trợ xác nhận thực tập và cung cấp thông tin cần thiết để hoàn thành báo cáo thực tập.",
                        "Có cơ hội được xem xét trở thành nhân viên chính thức sau khi kết thúc kỳ thực tập.",
                        "Được làm việc trong môi trường trẻ trung, sáng tạo và có cơ hội phát triển chuyên môn lâu dài."
                    },
                      ThoiGianLamViec = new List<string>
                    {
                       "Thứ 2 – Thứ 6: 08:30 – 17:30.",
                        "Nghỉ trưa: 12:00 – 13:00.",
                        "Thứ 7, Chủ nhật: Nghỉ theo lịch làm việc của công ty.",
                        "Thời gian thực tập tối thiểu từ 3–6 tháng."
                    },
                      DiaDiemChiTiet = "Phòng Nghiên cứu và Phát triển sản phẩm Trà Lười tại TP. Hồ Chí Minh. Địa chỉ cụ thể sẽ được cung cấp khi ứng viên tham gia phỏng vấn.",
                      CachThucUngTuyen = "Ứng viên quan tâm vui lòng gửi CV kèm thông tin chuyên ngành, thời gian có thể thực tập và kinh nghiệm liên quan (nếu có) về bộ phận tuyển dụng của Trà Lười.",
                        TieuDeEmail = " [R&D INTERN] – HỌ VÀ TÊN",
                        LoiMoi = "Bạn yêu thích sáng tạo và phát triển những hương vị mới?\r\nHãy gia nhập đội ngũ R&D của Trà Lười và cùng tạo nên những sản phẩm đồ uống độc đáo!",
                        Email = "tuyendung@traluoi.com"
                },
                new Employees
                {
                    MaTD = 8,
                    ViTri = "Trợ lý kho",
                    DiaDiem = "Long Hậu, Long An",
                    MucLuong = "10.000.000 - 13.000.000 VNĐ/tháng",
                    HinhThuc = "Toàn thời gian",
                    KinhNghiem = "Từ 1 năm kinh nghiệm kho vận hoặc quản lý hàng hóa",
                    HanNop = "30/9/2026",
                    MoTaCongViec = new List<string>
                    {
                        "Hỗ trợ quản lý và sắp xếp hàng hóa, nguyên vật liệu, bao bì và dụng cụ phục vụ hoạt động kinh doanh của hệ thống Trà Lười.",
                        "Tiếp nhận hàng hóa từ nhà cung cấp, kiểm tra số lượng, chủng loại và tình trạng hàng trước khi nhập kho.",
                        "Thực hiện các thủ tục nhập kho, xuất kho và cập nhật thông tin hàng hóa vào hệ thống quản lý.",
                        "Theo dõi số lượng tồn kho, kiểm tra hạn sử dụng và chủ động báo cáo các mặt hàng sắp hết hoặc có nguy cơ thiếu hụt.",
                        "Phối hợp với bộ phận mua hàng và sản xuất để đảm bảo nguyên vật liệu được cung ứng đúng thời gian.",
                        "Tham gia kiểm kê kho định kỳ, đối chiếu số liệu thực tế với dữ liệu trên hệ thống và báo cáo chênh lệch.",
                        "Giám sát việc bảo quản hàng hóa, đảm bảo kho luôn sạch sẽ, gọn gàng và tuân thủ quy định an toàn.",
                        "Hỗ trợ phân công, theo dõi tiến độ công việc của nhân viên kho khi cần thiết.",
                        "Tổng hợp chứng từ nhập xuất, lập báo cáo tồn kho và báo cáo các vấn đề phát sinh cho quản lý."
                    },
                    YeuCau = new List<string>
                    {
                        "Tốt nghiệp Trung cấp, Cao đẳng trở lên chuyên ngành Quản lý kho, Logistics, Kế toán hoặc các ngành liên quan.",
                        "Có kinh nghiệm từ 1 năm trong lĩnh vực kho vận, quản lý hàng hóa hoặc vị trí tương đương.",
                        "Biết sử dụng Excel và các phần mềm quản lý kho cơ bản.",
                        "Có khả năng kiểm tra, đối chiếu số liệu và xử lý chứng từ nhập xuất kho.",
                        "Cẩn thận, trung thực, có trách nhiệm trong việc quản lý tài sản và hàng hóa.",
                        "Có khả năng sắp xếp công việc, quản lý thời gian và phối hợp với các bộ phận liên quan.",
                        "Có sức khỏe tốt, sẵn sàng hỗ trợ các công việc kiểm kê và sắp xếp hàng hóa tại kho.",
                        "Ưu tiên ứng viên từng làm việc trong lĩnh vực thực phẩm, đồ uống hoặc bán lẻ."
                    },
                    QuyenLoi = new List<string>
                    {
                        "Mức lương từ 10.000.000 - 13.000.000 VNĐ/tháng, thỏa thuận theo năng lực và kinh nghiệm.",
                        "Được tham gia đầy đủ BHXH, BHYT, BHTN theo quy định của pháp luật.",
                        "Được hưởng lương tháng 13, thưởng lễ, Tết và các khoản thưởng theo hiệu quả công việc.",
                        "Được đào tạo về quy trình quản lý kho, kiểm soát hàng hóa và sử dụng hệ thống quản lý nội bộ.",
                        "Có cơ hội phát triển lên vị trí Thủ kho hoặc Quản lý kho nếu đáp ứng tốt yêu cầu công việc.",
                        "Được cung cấp trang thiết bị và công cụ cần thiết để phục vụ công việc.",
                        "Được làm việc trong môi trường chuyên nghiệp, thân thiện và có sự hỗ trợ từ các bộ phận liên quan.",
                        "Được hưởng các chế độ nghỉ phép và phúc lợi khác theo chính sách công ty."
                    },
                    ThoiGianLamViec = new List<string>
                    {
                        "Thứ 2 - Thứ 7.",
                        "Thời gian: 08:00 - 17:00.",
                        "Nghỉ trưa theo quy định của công ty.",
                        "Có thể hỗ trợ tăng ca khi phát sinh nhu cầu nhập hàng, xuất hàng hoặc kiểm kê kho."
                    },
                    DiaDiemChiTiet = "Kho vận Trà Lười tại khu vực Long Hậu, huyện Cần Giuộc, tỉnh Long An. Địa chỉ làm việc cụ thể sẽ được trao đổi trong quá trình phỏng vấn.",
                    CachThucUngTuyen = "Ứng viên chuẩn bị CV nêu rõ kinh nghiệm làm việc, kỹ năng quản lý kho và thông tin liên hệ.",
                    TieuDeEmail = "  [LONG HẬU] - TRỢ LÝ KHO - HỌ VÀ TÊN",
                    LoiMoi = "Bạn có kinh nghiệm và mong muốn phát triển trong lĩnh vực kho vận? Hãy gia nhập đội ngũ Trà Lười ngay hôm nay!",
                    Email = "tuyendung@traluoi.com"
                }
            };

            Employees tuyenDung = dsTuyenDung.FirstOrDefault(x => x.MaTD == id);

            if (tuyenDung == null)
            {
                return HttpNotFound();
            }

            return View(tuyenDung);
        }
    }
}