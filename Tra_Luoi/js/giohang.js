/* cart-handler.js
   Quản lý giỏ hàng dùng localStorage key = 'egrocery_cart'
   - Thêm sản phẩm từ trang chi tiết (detail-pl-product.html)
   - Thêm sản phẩm từ trang list/index (index.html)
   - Cập nhật badge ở nav (.right-nav .cart span)
   - Khi đang ở cart.html: render danh sách + tăng / giảm / xóa sản phẩm
*/

(function () {
    // Đây là một Immediately Invoked Function Expression (IIFE).
    // Mục đích: tạo một phạm vi (scope) riêng để biến và hàm không xung đột
    // với các script khác trên trang. Hàm này tự chạy ngay khi được load.
  
    // Tên key dùng để lưu giỏ hàng trong localStorage
    const STORAGE_KEY = "egrocery_cart";
  
    // -------------------------------------------------
    //  HELPER FUNCTIONS — các hàm hỗ trợ
    // -------------------------------------------------
  
    /**
     * Chuyển tên sản phẩm thành dạng ID thân thiện (không khoảng trắng, chữ thường)
     * Ví dụ: "Red Apple 1kg" -> "red-apple-1kg"
     */
    function slugify(text) {
      // toString(): đảm bảo giá trị là chuỗi
      return text
        .toString()             // biến input thành chuỗi
        .toLowerCase()          // chuyển tất cả ký tự thành chữ thường
        .trim()                 // loại khoảng trắng ở đầu và cuối chuỗi
        .replace(/\s+/g, "-")   // thay mọi khoảng trắng (1 hoặc nhiều) thành dấu '-'
        .replace(/[^a-z0-9\-]/g, "") // loại bỏ ký tự không phải chữ/số/dấu '-'
        .replace(/\-+/g, "-");  // gộp nhiều dấu '-' liên tiếp thành 1
    }
  
    /**
     * Định dạng giá thành chuỗi có ký hiệu tiền tệ: 2 -> "$2.00"
     */
    function formatPrice(n) {
      // Number(n) chuyển n về số; toFixed(2) giữ 2 chữ số thập phân
      return "$" + Number(n).toFixed(2);
    }
  
    // -------------------------------------------------
    //  CART STORAGE — quản lý lưu trữ giỏ hàng
    // -------------------------------------------------
  
    /**
     * Lấy giỏ hàng từ localStorage.
     * Nếu không có hoặc lỗi -> trả mảng rỗng.
     */
    function getCart() {
      try {
        // localStorage lưu chuỗi, nên parse nó thành object/array bằng JSON.parse
        // Nếu không có key STORAGE_KEY thì trả về '[]' (chuỗi mảng rỗng)
        return JSON.parse(localStorage.getItem(STORAGE_KEY) || "[]");
      } catch (e) {
        // Nếu JSON.parse lỗi (dữ liệu bị hỏng), trả về mảng rỗng để tránh crash
        return [];
      }
    }
  
    /**
     * Lưu giỏ hàng vào localStorage.
     * Đồng thời cập nhật badge số lượng trên giao diện.
     */
    function saveCart(cart) {
      // JSON.stringify chuyển mảng/cart thành chuỗi để lưu vào localStorage
      localStorage.setItem(STORAGE_KEY, JSON.stringify(cart));
      // Sau khi lưu xong, cập nhật số lượng hiển thị ở icon giỏ hàng
      updateCartBadge();
    }
  
    // -------------------------------------------------
    //  UPDATE BADGE — hiển thị số lượng sản phẩm trong giỏ
    // -------------------------------------------------
  
    /**
     * Lấy tổng số sản phẩm và hiển thị lên icon giỏ hàng (cart badge).
     * Tổng được tính = tổng qty của từng sản phẩm.
     */
    function updateCartBadge() {
        const cart = getCart();
        const count = cart.reduce((s, i) => s + Number(i.qty || 0), 0);
    
        const cartBadge = document.querySelector(".cart .count");
    
        if (cartBadge) {
            cartBadge.textContent = count;
        }
    }
  
    // -------------------------------------------------
    //  ADD / MERGE PRODUCT — thêm sản phẩm vào giỏ
    // -------------------------------------------------
  
    /**
     * Thêm sản phẩm vào giỏ:
     * - Nếu sản phẩm chưa tồn tại -> thêm mới
     * - Nếu đã có -> cộng dồn số lượng
     *
     * product mong đợi là object có: { id, title, price, qty, img }
     */
    function addToCart(product) {
      // Kiểm tra product hợp lệ (có id)
      if (!product || !product.id) return;
  
      // Lấy giỏ hiện tại (mảng)
      const cart = getCart();
  
      // Tìm index sản phẩm đã tồn tại (so sánh bằng id)
      const idx = cart.findIndex((i) => i.id === product.id);
  
      if (idx === -1) {
        // Nếu chưa có trong giỏ => đẩy product mới vào mảng
        cart.push(product);
      } else {
        // Nếu đã có => cộng dồn số lượng (qty)
        cart[idx].qty = Number(cart[idx].qty || 0) + Number(product.qty || 0);
      }
  
      // Lưu lại giỏ mới
      saveCart(cart);
    }
  
    // -------------------------------------------------
    //  READ PRODUCT FROM DETAIL PAGE
    // -------------------------------------------------
  
    /**
     * Lấy thông tin sản phẩm từ trang chi tiết sản phẩm.
     * Hàm này phụ thuộc vào cấu trúc HTML của trang detail.
     * Trả về object: {id, title, price, qty, img}
     */
    function readProductFromDetailPage() {
      // querySelector lấy phần tử đầu tiên khớp selector
      const titleEl = document.querySelector(".product-info h1");
const priceEl = document.querySelector(".product-info h2");
const imgEl = document.querySelector(".product-image img");
const qtyInput = document.querySelector(".product-info input[type='number']");
  
      // Lấy chuỗi tên; nếu titleEl null thì fallback 'Product'
      const title = titleEl ? titleEl.textContent.trim() : "Product";
  
      // Lấy chuỗi giá rồi lọc bỏ ký tự không phải số (như '$' hoặc 'đ')
      const priceRaw = priceEl.textContent;
const priceNum = parseFloat(priceRaw.replace(/[^0-9]/g, ""));
  
      // Lấy src ảnh, nếu không có thì ''
      const img = imgEl ? imgEl.src : "";
  
      // Lấy số lượng từ input; đảm bảo ít nhất 1
      const qty = qtyInput ? Math.max(1, parseInt(qtyInput.value || "1")) : 1;
  
      // Tạo id từ title bằng slugify để so sánh trong giỏ
      const id = slugify(title);
  
      // Trả về object sản phẩm
      return { id, title, price: priceNum, qty: Number(qty), img };
    }
  
    // -------------------------------------------------
    //  READ PRODUCT FROM LIST PAGE (index.html)
    // -------------------------------------------------
  
    /**
     * Lấy thông tin sản phẩm từ layout danh sách (index, category…).
     * Dùng khi user bấm nút "Add Cart" ở danh sách.
     * Tham số el là nút (button / a) được bấm.
     */
    function readProductFromList(el) {
      // Tìm container cha gần nhất chứa thông tin sản phẩm bằng một vài selector phổ biến
      const box =
        el.closest(".product-box") ||
        el.closest(".col-md-3") ||
        el.closest(".product-container") ||
        el.closest(".category-box");
  
      // Nếu không tìm được container -> trả về null (không xử lý)
      if (!box) return null;
  
      // Tìm các phần tử title/price/img trong container
      const titleEl =
        box.querySelector("strong") ||
        box.querySelector(".title") ||
        box.querySelector("h3");
  
      const priceEl =
        box.querySelector(".price") || box.querySelector(".price-tag");
  
      const imgEl = box.querySelector("img");
  
      // Có thể có ô nhập qty trong product box (không bắt buộc)
      let qtyEl = box.querySelector('input[type="number"]');
  
      // Lấy giá trị thực tế, dùng fallback nếu không tìm thấy
      const title = titleEl ? titleEl.textContent.trim() : "Product";
  
      const priceRaw = priceEl ? priceEl.textContent.trim() : "0";
      const priceNum = parseFloat(priceRaw.replace(/[^0-9.]/g, "")) || 0;
  
      const img = imgEl ? imgEl.src : "";
  
      const qty = qtyEl ? Math.max(1, parseInt(qtyEl.value || "1")) : 1;
  
      const id = slugify(title);
  
      // Trả về object product
      return { id, title, price: priceNum, qty: Number(qty), img };
    }
  
    // -------------------------------------------------
    //  TOAST — thông báo nhỏ dạng popup
    // -------------------------------------------------
  
    /**
     * Hiển thị thông báo popup nhỏ (toast) ở góc màn hình trong 1.4s.
     * Dùng để feedback nhanh cho người dùng khi thêm sản phẩm.
     */
    function toast(text) {
      try {
        // Tạo 1 div mới
        const t = document.createElement("div");
        // Gán nội dung text
        t.textContent = text;
        // Tùy biến style trực tiếp (đơn giản)
        t.style.position = "fixed";
        t.style.right = "20px";
        t.style.bottom = "20px";
        t.style.background = "#4eb060";
        t.style.color = "#fff";
        t.style.padding = "10px 14px";
        t.style.borderRadius = "8px";
        t.style.boxShadow = "0 6px 20px rgba(0,0,0,0.12)";
        t.style.zIndex = 9999;
  
        // Thêm vào body để hiển thị
        document.body.appendChild(t);
        // Sau 1400ms tự remove element
        setTimeout(() => t.remove(), 1400);
      } catch (e) {
        // Nếu có lỗi (ví dụ document.body undefined), bỏ qua để không làm vỡ app
      }
    }
  
    // -------------------------------------------------
    //  RENDER CART PAGE — tạo hiển thị giỏ hàng tại cart.html
    // -------------------------------------------------
  
    /**
     * Render (vẽ) danh sách sản phẩm khi đang ở trang cart.html.
     * Hàm này:
     * - Tìm vùng chứa giỏ hàng (container)
     * - Nếu giỏ rỗng: hiển thị trạng thái rỗng
     * - Nếu có sản phẩm: dựng HTML cho từng item và gán sự kiện
     */
    function renderCartPage() {
      // Tìm phần tử root nơi ta sẽ render giỏ hàng
      const root = document.querySelector(".cart-content");
  
      // Nếu không tồn tại vùng render trên trang hiện tại, thoát hàm
      if (!root) return;
  
      // Lấy dữ liệu giỏ và container để chèn nội dung
      const cart = getCart();
      const container = root;
      const emptyEl = document.getElementById("cart-empty");
  
      // Nếu giỏ rỗng hoặc không có phần tử
      if (!cart || cart.length === 0) {
        // Xoá nội dung cũ (nếu có)
        if (container) container.innerHTML = "";
        // Hiện thông báo giỏ trống nếu có phần tử emptyEl
        if (emptyEl) emptyEl.hidden = false;
        // Cập nhật lại tổng (sẽ hiển thị 0)
        updateTotals();
        return; // dừng ở đây
      }
  
      // Nếu có sản phẩm -> ẩn empty state
      if (emptyEl) emptyEl.hidden = true;
  
      // Xoá nội dung cũ trước khi render lại
      container.innerHTML = "";
  
      // Duyệt từng item trong giỏ để tạo node HTML hiển thị
      cart.forEach((item) => {
        // Tạo một div chứa 1 hàng sản phẩm
        const row = document.createElement("div");
        row.className = "cart-item";
  
        // Dùng template string để dựng nội dung HTML cho 1 item
        row.innerHTML = `
          <img src="${item.img || "images/no-image.png"}" />
          <div class="meta">
            <strong>${item.title}</strong>
  
            <div class="qty-controls">
              <button class="qty-btn" data-id="${item.id}" data-op="-">−</button>
  
              <input class="qty-input" type="number" min="1"
                value="${item.qty}" data-id="${item.id}" />
  
              <button class="qty-btn" data-id="${item.id}" data-op="+">+</button>
  
              <button class="remove" data-id="${item.id}">Xóa</button>
            </div>
          </div>
  
          <div class="price">${formatPrice(item.price * item.qty)}</div>
        `;
  
        // Thêm hàng vừa tạo vào container
        container.appendChild(row);
      });
  
      // Sau khi render xong, gán sự kiện cho các nút tăng/giảm/xóa
      container.querySelectorAll(".qty-btn").forEach((b) =>
        b.addEventListener("click", function (e) {
          // data-id chứa id sản phẩm; data-op là '+' hoặc '-'
          const id = e.currentTarget.dataset.id;
          const op = e.currentTarget.dataset.op;
          // Nếu op === '+' thì delta = +1, ngược lại -1
          changeQty(id, op === "+" ? 1 : -1);
        })
      );
  
      // Gán sự kiện khi người dùng trực tiếp nhập số trong input
      container.querySelectorAll(".qty-input").forEach((inp) =>
        inp.addEventListener("change", function (e) {
          const id = e.target.dataset.id;
          // parse int và đảm bảo ít nhất là 1
          const v = Math.max(1, parseInt(e.target.value || "1"));
          setQty(id, v);
        })
      );
  
      // Gán sự kiện xóa từng item
      container.querySelectorAll(".remove").forEach((b) =>
        b.addEventListener("click", function (e) {
          removeItem(e.currentTarget.dataset.id);
        })
      );
  
      // Cập nhật tổng tiền sau khi render
      updateTotals();
    }
  
    // -------------------------------------------------
    //  CART ITEM OPERATIONS — tăng / giảm / xóa
    // -------------------------------------------------
  
    /**
     * Tăng hoặc giảm số lượng sản phẩm theo delta (+1 hoặc -1)
     * - Nếu giảm xuống dưới 1 => giữ 1 (không cho 0 hoặc âm)
     */
    function changeQty(id, delta) {
      // Lấy giỏ hiện tại
      const cart = getCart();
      // Tìm index sản phẩm theo id
      const idx = cart.findIndex((i) => i.id === id);
      if (idx === -1) return; // nếu không tìm thấy thì không làm gì
  
      // Cập nhật qty, đảm bảo tối thiểu 1
      cart[idx].qty = Math.max(1, Number(cart[idx].qty || 0) + delta);
      // Lưu lại và render lại trang
      saveCart(cart);
      renderCartPage();
    }
  
    /**
     * Đặt số lượng sản phẩm bằng giá trị mới (khi user nhập trực tiếp)
     */
    function setQty(id, qty) {
      const cart = getCart();
      const idx = cart.findIndex((i) => i.id === id);
      if (idx === -1) return;
  
      cart[idx].qty = Math.max(1, Number(qty));
      saveCart(cart);
      renderCartPage();
    }
  
    /**
     * Xóa 1 sản phẩm khỏi giỏ (theo id)
     */
    function removeItem(id) {
      // Lấy giỏ và lọc bỏ item có id trùng
      let cart = getCart();
      cart = cart.filter((i) => i.id !== id);
      // Lưu lại và render
      saveCart(cart);
      renderCartPage();
    }
  
    // -------------------------------------------------
    //  TOTALS — tính tiền
    // -------------------------------------------------
  
    /**
     * Tính tổng tiền:
     * subtotal = tổng giá * số lượng
     * delivery = phí giao hàng (ở đây mặc định 2.0 nếu có item)
     * discount = giảm giá (hiện để 0.0)
     * total = subtotal + delivery - discount
     * Sau đó gán tổng vào phần tử tương ứng trên trang
     */
    function updateTotals() {
      const cart = getCart();
  
      // Tính subtotal (dùng reduce)
      const subtotal = cart.reduce((s, i) => s + i.price * i.qty, 0);
      // Phí giao hàng đơn giản: nếu có item thì 2.0, ngược lại 0
      const delivery = cart.length ? 2.0 : 0.0;
      const discount = 0.0;
      const total = subtotal + delivery - discount;
  
      // Lấy các phần tử DOM nơi hiển thị số tiền
      const elSubtotal = document.getElementById("subtotal");
      const elDelivery = document.getElementById("delivery");
      const elDiscount = document.getElementById("discount");
      const elTotal = document.getElementById("total");
  
      // Nếu phần tử tồn tại thì gán textContent = giá đã format
      if (elSubtotal) elSubtotal.textContent = formatPrice(subtotal);
      if (elDelivery) elDelivery.textContent = formatPrice(delivery);
      if (elDiscount) elDiscount.textContent = "-" + formatPrice(discount);
      if (elTotal) elTotal.textContent = formatPrice(total);
    }
  
    // -------------------------------------------------
    //  ATTACH BUTTON HANDLERS — kết nối các nút Add Cart & Buy Now
    // -------------------------------------------------
  
    /**
     * Gán sự kiện cho tất cả nút Add Cart / Buy Now / Clear Cart / Checkout.
     * Hàm này chạy trên mọi trang (index, detail, cart).
     */
    function attachButtons() {
      // Tìm nút "Add" và "Buy Now" trên trang chi tiết (nếu có)
      const addBtn = document.querySelector(".btn-add");
      const buyBtn = document.querySelector(".btn-buy");
  
      if (addBtn) {
        // Khi click nút add => đọc thông tin từ trang detail, thêm vào giỏ, hiện toast
        addBtn.addEventListener("click", function () {
          const p = readProductFromDetailPage();
          addToCart(p);
          toast("Đã thêm vào giỏ hàng");
        });
      }
  
      if (buyBtn) {
        // Khi click buy => thêm vào giỏ rồi chuyển trang tới cart.html
        buyBtn.addEventListener("click", function () {
          const p = readProductFromDetailPage();
          addToCart(p);
          window.location.href = "cart.html"; // chuyển trang
        });
      }
  
      // Tìm mọi nút add trên trang danh sách (có thể có nhiều class khác nhau)
      document
        .querySelectorAll(".cart-btn, .cart-btn1, .cart-btn2, .cart-btn3")
        .forEach((btn) => {
          btn.addEventListener("click", function (e) {
            e.preventDefault(); // nếu là <a> thì chặn hành vi chuyển trang mặc định
  
            const p = readProductFromList(btn); // đọc thông tin sản phẩm dựa trên nút
            if (!p) {
              // nếu không lấy được thông tin -> báo user
              toast("Không thể lấy thông tin sản phẩm.");
              return;
            }
  
            addToCart(p); // thêm sản phẩm vào giỏ
            toast("Đã thêm vào giỏ hàng");
          });
        });
  
      // Nút clear-cart (xóa toàn bộ giỏ)
      const clearBtn = document.getElementById("clear-cart");
      if (clearBtn) {
        clearBtn.addEventListener("click", function () {
          // Xóa key trong localStorage
          localStorage.removeItem(STORAGE_KEY);
          // Cập nhật badge và UI
          updateCartBadge();
          renderCartPage();
        });
      }
  
      // Nút checkout (chỉ demo)
      const checkoutBtn = document.getElementById("checkout");
      if (checkoutBtn) {
        checkoutBtn.addEventListener("click", function () {
          // Ở đây bạn sẽ tích hợp cổng thanh toán thực tế
          alert("Chưa tích hợp cổng thanh toán.");
        });
      }
    }
  
    // -------------------------------------------------
    //  INIT — chạy khi trang load xong
    // -------------------------------------------------
  
    /**
     * Khi trang load xong:
     * - cập nhật badge (số lượng)
     * - gán sự kiện cho các nút
     * - nếu đang ở cart.html -> render giỏ hàng
     */
    document.addEventListener("DOMContentLoaded", function () {
      updateCartBadge(); // cập nhật số lượng trên icon
      attachButtons();   // gán handler cho các nút
      renderCartPage();  // nếu có phần tử cart trên trang => render
    });
  
    // -------------------------------------------------
    //  OPTIONAL EXPORTED API
    // -------------------------------------------------
  
    /**
     * Expose một vài hàm ra biến toàn cục window.egrocery_cart
     * để bạn có thể debug, gọi từ console hoặc dùng trong mã khác.
     * Ví dụ mở devtools và gõ: egrocery_cart.getCart()
     */
    window.egrocery_cart = {
      getCart,
      saveCart,
      addToCart,
      removeItem,
      setQty,
      changeQty,
      updateCartBadge,
    };
  })();
  