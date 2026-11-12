using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tra_Luoi.Models;

namespace Tra_Luoi.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult Details(int id)
        {
            List<News> dsTin = new List<News>()
            {
                new News
                {
                    MaTin = 1,
                    TieuDe = "TRÀ LƯỜI RA MẮT HƯƠNG VỊ MỚI",
                    HinhAnh = "~/img/z7955591122776_a62d0510c6368ee2f32266696ef6c322.jpg",
                    NgayDang = "06/11/2026",
                    MoTa = "Khám phá những hương vị trà mới được Trà Lười giới thiệu dành cho những ngày thư giãn. Sự kết hợp giữa trà thanh mát và trái cây tươi mang đến trải nghiệm thưởng thức đầy mới mẻ.",
                    GioiThieu = "Với mong muốn mang đến những trải nghiệm mới cho khách hàng, Trà Lười chính thức giới thiệu dòng thức uống mới được kết hợp từ trà thơm ngon và các loại trái cây tươi tự nhiên.\r\n\r\nSản phẩm được chăm chút từ hương vị đến hình thức, tạo nên sự hài hòa giữa vị trà thanh nhẹ, vị chua ngọt của trái cây và cảm giác tươi mát khi thưởng thức.",
                    DiemNoiBat = "Điểm đặc biệt của dòng sản phẩm lần này nằm ở sự kết hợp nguyên liệu tươi ngon, hương vị cân bằng và cách trình bày bắt mắt. Đây sẽ là lựa chọn phù hợp cho những ngày hè hoặc những lúc bạn muốn tìm kiếm một thức uống giải khát.",
                    TraiNghiem = "Trà Lười hy vọng những hương vị mới sẽ mang đến cho khách hàng những phút giây thư giãn và những trải nghiệm đáng nhớ. Hãy ghé cửa hàng để khám phá và thưởng thức sản phẩm mới ngay hôm nay!"
                },

                new News
                {
                    MaTin = 2,
                    TieuDe = "TRÀ TRÁI CÂY - TƯƠI MÁT MỖI NGÀY",
                    HinhAnh = "~/img/z7955591126707_011760d26a9173924fa86438906542d7.jpg",
                    NgayDang = "06/11/2026",
                    MoTa = "Sự kết hợp giữa trà thanh mát và trái cây tươi tạo nên thức uống thơm ngon, phù hợp cho những ngày hè.",
                    GioiThieu = "Trà trái cây là sự kết hợp giữa nền trà thơm nhẹ cùng các loại trái cây tươi như cam, chanh, dâu, đào và nhiều loại trái cây khác. Mỗi nguyên liệu mang đến một hương vị riêng, tạo nên sự hòa quyện độc đáo trong từng ly thức uống.\r\n\r\nVị chát nhẹ của trà kết hợp cùng vị chua ngọt tự nhiên của trái cây giúp thức uống trở nên cân bằng, dễ thưởng thức và phù hợp với nhiều đối tượng khách hàng.",
                    DiemNoiBat = "Điểm nổi bật của trà trái cây nằm ở hương thơm tự nhiên, màu sắc bắt mắt và cảm giác thanh mát khi thưởng thức. Những lát trái cây tươi được kết hợp cùng trà và đá lạnh tạo nên thức uống hấp dẫn cả về hương vị lẫn hình thức.\r\n\r\nVới nhiều lựa chọn trái cây khác nhau, khách hàng có thể khám phá những hương vị mới mẻ, từ vị chua dịu của cam chanh đến vị ngọt thơm của đào và dâu.",
                    TraiNghiem = "Trà Lười mong muốn mang đến cho khách hàng những thức uống thơm ngon, chất lượng và phù hợp với nhu cầu giải khát mỗi ngày. Mỗi ly trà đều được chăm chút trong cách kết hợp nguyên liệu và trình bày.\r\n\r\nHãy ghé Trà Lười để khám phá những hương vị trà trái cây tươi mát và tận hưởng những phút giây thư giãn cùng bạn bè, người thân ngay hôm nay!"
                },
            new News
            {
                MaTin = 3,
                TieuDe = "ƯU ĐÃI ĐẶC BIỆT DÀNH CHO BẠN",
                HinhAnh = "~/img/Gemini_Generated_Image_521q48521q48521q.png",
                NgayDang = "06/11/2026",
                MoTa = "Đừng bỏ lỡ những chương trình ưu đãi hấp dẫn dành riêng cho khách hàng của Trà Lười. Với mong muốn mang đến trải nghiệm tốt nhất, chúng tôi luôn có những chương trình khuyến mãi đặc biệt dành cho bạn.",
                GioiThieu = "Trà Lười mang đến nhiều chương trình ưu đãi hấp dẫn nhằm tri ân khách hàng đã luôn tin tưởng và lựa chọn sản phẩm của chúng tôi. Đây là cơ hội tuyệt vời để bạn thưởng thức những thức uống yêu thích với mức giá tiết kiệm.\r\n\r\nCác chương trình ưu đãi được thiết kế đa dạng, phù hợp với nhiều nhu cầu khác nhau, giúp khách hàng có thêm nhiều lựa chọn khi mua sắm và thưởng thức đồ uống tại Trà Lười.",
                DiemNoiBat = "Khách hàng có thể nhận được nhiều ưu đãi đặc biệt như giảm giá trực tiếp trên sản phẩm, ưu đãi khi mua nhiều thức uống hoặc các chương trình quà tặng hấp dẫn.\r\n\r\nBên cạnh đó, Trà Lười thường xuyên cập nhật những chương trình mới vào các dịp đặc biệt để mang đến nhiều trải nghiệm thú vị và lợi ích thiết thực cho khách hàng.",
                TraiNghiem = "Hãy thường xuyên theo dõi trang tin tức và khuyến mãi của Trà Lười để cập nhật những chương trình mới nhất. Đừng bỏ lỡ cơ hội thưởng thức những thức uống thơm ngon với nhiều ưu đãi hấp dẫn.\r\n\r\nTrà Lười rất vui khi được đồng hành cùng bạn trong những khoảnh khắc thư giãn. Ghé cửa hàng ngay hôm nay để khám phá các chương trình ưu đãi đặc biệt nhé!"
                },
            new News
            {
                MaTin = 4,
                TieuDe = "TRÀ SỮA TRÀ LƯỜI - VỊ NGON KHÓ CƯỠNG",
                HinhAnh = "~/img/z7955591122394_66912c1fd6e7f7a8187070b7aa72dbe0.jpg",
                NgayDang = "06/11/2026",
                GioiThieu = "TNhững ly trà sữa thơm ngon với nhiều lựa chọn topping hấp dẫn dành cho tín đồ yêu trà sữa. Sự kết hợp giữa trà thơm, sữa béo ngậy và những loại topping đa dạng mang đến trải nghiệm thưởng thức khó quên.",
                MoTa = "Trà sữa luôn là một trong những thức uống được nhiều khách hàng yêu thích nhờ hương vị thơm ngon và sự kết hợp hài hòa giữa trà và sữa. Tại Trà Lười, mỗi ly trà sữa đều mang đến cảm giác béo thơm, ngọt dịu và dễ dàng chinh phục vị giác ngay từ lần thưởng thức đầu tiên.\r\n\r\nHương trà đặc trưng hòa quyện cùng vị sữa béo nhẹ tạo nên thức uống cân bằng, không quá ngọt và phù hợp để thưởng thức trong những buổi gặp gỡ bạn bè hoặc những lúc cần một chút thư giãn.",     
                DiemNoiBat = "Một trong những điểm hấp dẫn của trà sữa chính là sự đa dạng của các loại topping. Từ trân châu dai mềm, thạch giòn mát đến những loại topping thơm ngon khác, tất cả đều góp phần tạo nên trải nghiệm thú vị trong từng ngụm trà sữa.\r\n\r\nKhách hàng có thể lựa chọn và kết hợp những loại topping yêu thích để tạo nên ly trà sữa mang hương vị riêng. Sự phong phú trong cách kết hợp giúp mỗi lần thưởng thức đều trở nên mới mẻ và hấp dẫn hơn.",
                TraiNghiem = "Với mong muốn mang đến những thức uống thơm ngon và chất lượng, Trà Lười luôn chú trọng đến hương vị cũng như trải nghiệm của khách hàng. Mỗi ly trà sữa không chỉ là một thức uống giải khát mà còn là lựa chọn tuyệt vời cho những phút giây thư giãn trong ngày.\r\n\r\nNếu bạn là tín đồ của trà sữa, đừng bỏ lỡ cơ hội khám phá những hương vị hấp dẫn tại Trà Lười. Hãy ghé cửa hàng và lựa chọn ngay cho mình một ly trà sữa yêu thích nhé!"
            },
            new News
            {
                MaTin = 5,
                TieuDe = "TRÀ LƯỜI - ƯU ĐÃI MỖI NGÀY",
                HinhAnh = "~/img/z7955591130217_4bba29551173b25a61e5cfb01086b19b.jpg",
                NgayDang = "06/11/2026",
                GioiThieu = "Cùng Trà Lười tận hưởng những chương trình khuyến mãi hấp dẫn trong tháng. Mỗi ngày đều có thêm những cơ hội thú vị để bạn thưởng thức đồ uống yêu thích với nhiều lợi ích hấp dẫn.",
                MoTa = "Trà Lười thường xuyên mang đến những chương trình ưu đãi mới nhằm giúp khách hàng có thêm nhiều lựa chọn khi thưởng thức đồ uống. Các chương trình được cập nhật theo từng thời điểm, tạo nên nhiều trải nghiệm thú vị cho khách hàng trong suốt tháng.\r\n\r\nTừ những thức uống quen thuộc đến các sản phẩm được nhiều người yêu thích, khách hàng có thể tìm thấy những ưu đãi phù hợp với sở thích và nhu cầu của mình.",     
                DiemNoiBat = "Không chỉ mang đến những thức uống thơm ngon, Trà Lười còn mong muốn giúp khách hàng có những trải nghiệm mua sắm tiết kiệm và thuận tiện hơn. Những chương trình khuyến mãi là cơ hội để bạn thưởng thức nhiều sản phẩm yêu thích với mức giá hấp dẫn.\r\n\r\nĐây cũng là dịp tuyệt vời để bạn khám phá thêm những hương vị mới, lựa chọn thức uống phù hợp và chia sẻ những khoảnh khắc vui vẻ cùng bạn bè, người thân.",
                TraiNghiem = "Các chương trình khuyến mãi có thể thay đổi tùy theo từng thời điểm và số lượng áp dụng. Vì vậy, hãy thường xuyên theo dõi website Trà Lười để không bỏ lỡ những thông tin ưu đãi mới nhất.\r\n\r\nTrà Lười luôn mong muốn mang đến nhiều niềm vui và trải nghiệm tốt hơn cho khách hàng. Hãy ghé thăm cửa hàng và tận hưởng những chương trình ưu đãi hấp dẫn ngay hôm nay!"
            },
            new News
            {
                MaTin = 6,
                TieuDe = "KHÁM PHÁ MENU MỚI CỦA TRÀ LƯỜI",
                HinhAnh = "~/img/z7955591126655_dec5e1f78c4baf7ce70fbefacd00102e.jpg",
                NgayDang = "06/11/2026",
                GioiThieu = "Cập nhật những thức uống mới và lựa chọn yêu thích của bạn tại Trà Lười. Với menu đa dạng và nhiều hương vị hấp dẫn, khách hàng sẽ có thêm nhiều lựa chọn phù hợp với sở thích của mình.",
                MoTa = "Nhằm mang đến những trải nghiệm phong phú hơn cho khách hàng, Trà Lười không ngừng cập nhật và phát triển thực đơn với nhiều lựa chọn thức uống hấp dẫn. Mỗi sản phẩm đều mang đến một hương vị riêng, giúp khách hàng dễ dàng tìm thấy thức uống phù hợp với khẩu vị của mình.\r\n\r\nTừ những ly cà phê thơm đậm đà đến các loại trà thanh mát và thức uống trái cây tươi ngon, menu mới hứa hẹn mang đến nhiều trải nghiệm thú vị cho những ai yêu thích khám phá đồ uống.",     
                DiemNoiBat = "Điểm đặc biệt của menu Trà Lười là sự đa dạng trong các dòng thức uống. Khách hàng có thể lựa chọn cà phê với hương vị đậm đà, trà sữa béo thơm hoặc những loại trà trái cây mang cảm giác thanh mát và dễ chịu.\r\n\r\nKhông chỉ đa dạng về hương vị, các sản phẩm còn được chú trọng trong cách trình bày, tạo nên những ly thức uống bắt mắt và hấp dẫn. Đây cũng là cơ hội để bạn thử nghiệm những sự kết hợp mới và tìm ra món đồ uống yêu thích của mình.",
                TraiNghiem = "Dù bạn yêu thích cà phê để bắt đầu ngày mới hay muốn tìm một thức uống mát lạnh để thư giãn, menu của Trà Lười luôn có những lựa chọn đáng để khám phá.\r\n\r\nHãy ghé Trà Lười cùng bạn bè và người thân để trải nghiệm thực đơn mới, khám phá những hương vị hấp dẫn và tìm cho mình một thức uống yêu thích nhé!"
            }
             };

            News tin = dsTin.FirstOrDefault(x => x.MaTin == id);

            if (tin == null)
            {
                return HttpNotFound();
            }

            return View(tin);
        }
    }
}