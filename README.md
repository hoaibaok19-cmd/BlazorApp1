# Bao Truong — Photography Portfolio

Website portfolio cá nhân của **Bao Truong** — nhiếp ảnh gia (chân dung, ảnh cưới, đời thường & phong cảnh). Trang web được viết bằng **Blazor WebAssembly (.NET 10)** và tự động deploy lên **GitHub Pages** bằng GitHub Actions.

🔗 **Live:** https://hoaibaok19-cmd.github.io/BlazorApp1/

## ✅ Việc cần làm trước khi công khai

Nội dung hiện tại là **bản nháp**: chữ dùng vai trò nhiếp ảnh gia, còn ảnh là ảnh mẫu ngẫu nhiên từ picsum.photos. Hãy mở [`BlazorApp1/wwwroot/data/portfolio.json`](BlazorApp1/wwwroot/data/portfolio.json), tìm các dòng `// TODO` và thay bằng đồ thật:

- [ ] **Ảnh thật của bạn** — chép vào `BlazorApp1/wwwroot/images/gallery/` rồi thay các link `picsum.photos` trong `gallery` và `profile.heroImage`
- [ ] Họ tên đầy đủ có dấu (`profile.name`)
- [ ] Email cá nhân (`profile.email` và mục `Email` trong `socials`)
- [ ] Link Instagram và Facebook (`socials`)
- [ ] Thành phố, năm bắt đầu cầm máy, số liệu ở `stats`
- [ ] Danh sách thiết bị trong `toolbox`

## Tính năng

- Trang one-page gồm Hero ảnh toàn màn hình, Thư viện ảnh (gallery), Giới thiệu, Dịch vụ, và Liên hệ.
- **Thư viện ảnh dạng masonry** với bộ lọc theo thể loại và **lightbox** xem ảnh phóng to (bấm ảnh, chuyển ảnh bằng mũi tên ◀ ▶ hoặc phím ← →, đóng bằng Esc).
- Song ngữ **English / Tiếng Việt**: có nút chuyển ngôn ngữ, lần đầu vào trang sẽ tự chọn theo ngôn ngữ của trình duyệt.
- Giao diện **Dark / Light** theo phong cách nhiếp ảnh (tông ấm, chữ serif Playfair Display): lần đầu theo hệ điều hành, lựa chọn sau đó được lưu trong `localStorage`.
- **Toàn bộ nội dung nằm trong một file JSON** nên không cần sửa code khi cập nhật.
- Hiệu ứng reveal khi cuộn trang, scroll-spy trên thanh menu, form liên hệ.
- Responsive cho mobile, tablet và desktop; hỗ trợ accessibility (skip link, điều hướng bằng bàn phím, `prefers-reduced-motion`).
- Có trang 404 riêng. Deep link (ví dụ `/#gallery`) hoạt động trên GitHub Pages.

## Cấu trúc thư mục

```
.github/workflows/deploy.yml   # CI/CD: build và deploy lên GitHub Pages
BlazorApp1/
├── wwwroot/
│   ├── data/portfolio.json    # ⭐ TOÀN BỘ NỘI DUNG CỦA WEBSITE
│   ├── images/gallery/        # Ảnh của bạn (tự tạo khi thêm ảnh)
│   ├── css/app.css            # Design system (màu sắc, layout, animation)
│   ├── js/site.js             # Scroll-spy, reveal animation, dialog, clipboard
│   └── index.html             # Trang khung, màn hình loading, meta SEO
├── Sections/                  # Các section: Hero, Gallery, About, Skills, Contact
├── Components/                # Component dùng chung: Icon, Lightbox, SocialLinks, ...
├── Layout/                    # MainLayout, NavBar, SiteFooter
├── Services/
│   ├── SiteState.cs           # Ngôn ngữ, theme, dữ liệu, section đang active
│   └── UiText.cs              # Nhãn giao diện EN/VI (menu, nút, thông báo)
└── Models/                    # Schema của portfolio.json
```

## ✏️ Chỉnh sửa nội dung

### Văn bản song ngữ

Mọi trường văn bản đều nhận một trong hai dạng sau:

```jsonc
"tagline": "Same text for both languages",
"tagline": { "en": "English text", "vi": "Nội dung tiếng Việt" }
```

Nếu một ngôn ngữ bị thiếu, trang sẽ tự dùng ngôn ngữ còn lại. File cho phép viết comment (`//`) và dấu phẩy cuối danh sách.

### Các phần chính

| Khóa | Nội dung |
|---|---|
| `profile` | Tên, `initials`, `roles` (hiển thị ở Hero, nên ≤ ~28 ký tự), `tagline`, `availability` (để trống thì ẩn huy hiệu), `heroImage` (ảnh nền Hero), `location`, `email`, `phone`, `cv` |
| `socials` | Danh sách `{ "name", "icon", "url" }`, dùng ở Hero, Liên hệ và Footer |
| `about` | `paragraphs`, `facts` (`icon`, `label`, `value`) và `stats` (`value` là số nguyên có hiệu ứng đếm, `suffix` như `+`, `K+` hoặc `%`) |
| `skillGroups` | Nhóm dịch vụ. Kỹ năng/dịch vụ có `level` (0–100) hiển thị dạng thanh; không có `level` thì hiển thị dạng chip. `name` có thể song ngữ |
| `toolbox` | Thiết bị trong túi máy, hiển thị dạng chip |
| `experience`, `education` | Timeline tùy chọn (`title`, `organization`, `url`, `period`, `location`, `description`, `highlights`, `tags`). Để `[]` sẽ ẩn hẳn phần này |
| `gallery` | Mỗi ảnh gồm `id`, `image` (ảnh phóng to), `thumb` (ảnh nhỏ cho lưới — không bắt buộc), `title`, `category` (dùng làm bộ lọc), `caption`, `location`, `year`, `featured` (ô lớn) |
| `contact` | `heading`, `text` (không bắt buộc) và `formspreeId` |

Muốn ẩn một section thì để trống dữ liệu của nó, ví dụ `"gallery": []`. Section đó và mục menu tương ứng sẽ tự ẩn.

### Ảnh thư viện, ảnh Hero và CV

Đặt file vào `BlazorApp1/wwwroot/` rồi khai báo bằng **đường dẫn tương đối, không có dấu `/` ở đầu**:

```jsonc
"heroImage": "images/hero.jpg",
// trong một ảnh gallery:
"image": "images/gallery/01.jpg",
"thumb": "images/gallery/01-thumb.jpg"   // không bắt buộc; thiếu thì dùng luôn "image"
```

- `category` (phần tiếng Anh) được dùng để gom nhóm bộ lọc — giữ nhất quán giữa các ảnh (ví dụ `Portrait`, `Wedding`, `Street`, `Landscape`, `Travel`).
- Ảnh Hero nên là ảnh ngang, rộng ~1920px. Ảnh gallery nên xuất cạnh dài ~1600px; `thumb` ~800px để lưới tải nhanh hơn.
- Nếu `cv` để trống, nút tải CV sẽ ẩn.

### Icon

Các trường `icon` nhận tên lấy từ bộ [Feather Icons](https://feathericons.com). Các tên đang có sẵn:

`activity` `alert-circle` `arrow-right` `arrow-up` `arrow-up-right` `award` `bar-chart` `book` `book-open` `box` `briefcase` `calendar` `check` `check-circle` `clipboard` `cloud` `code` `coffee` `compass` `copy` `cpu` `crosshair` `database` `download` `external-link` `facebook` `file-text` `folder` `git-branch` `github` `globe` `grid` `heart` `home` `info` `instagram` `layers` `layout` `linkedin` `mail` `map` `map-pin` `menu` `message-circle` `monitor` `moon` `package` `pen-tool` `phone` `send` `server` `smartphone` `star` `sun` `target` `terminal` `tool` `trending-up` `twitter` `user` `users` `x` `youtube` `zap`

Muốn thêm icon khác: copy phần nội dung bên trong thẻ `<svg>` từ feathericons.com vào `Components/IconPaths.cs`.

### Form liên hệ

- **Mặc định** (`formspreeId` để trống): khi gửi form, trang sẽ mở ứng dụng email của người xem và điền sẵn nội dung.
- **Gửi trực tiếp**: tạo form miễn phí tại [formspree.io](https://formspree.io), rồi điền ID của form (ví dụ `"xyzabcd"`) vào `contact.formspreeId`.

### Nhãn giao diện, màu sắc và favicon

- Chữ trên menu, nút bấm và thông báo nằm trong `Services/UiText.cs`.
- Màu thương hiệu, gradient và theme được khai báo bằng CSS variables ở đầu file `wwwroot/css/app.css` (`--brand-1`, `--brand-2`, `--brand-3`).
- Favicon nằm ở `wwwroot/favicon.svg` (chữ `BT`); `favicon.png` và `icon-192.png` là bản PNG của cùng biểu tượng.
- Tiêu đề trang, mô tả SEO và chữ trên màn hình loading nằm trong `wwwroot/index.html`.

## 💻 Chạy trên máy

Cần cài [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
cd BlazorApp1
dotnet watch
```

Sau đó mở http://localhost:5231. Mỗi khi sửa `portfolio.json`, chỉ cần tải lại trang để thấy thay đổi.

## 🚀 Deploy lên GitHub Pages

Workflow [`.github/workflows/deploy.yml`](.github/workflows/deploy.yml) tự động build và deploy mỗi khi có commit được push lên nhánh `master` hoặc `main`. Bạn cũng có thể chạy tay trong tab **Actions**.

Thiết lập một lần:

1. **Repository phải ở chế độ Public.** GitHub Pages cho repo Private chỉ dùng được với gói GitHub Pro/Team/Enterprise. Đổi chế độ tại *Settings → General → Danger Zone → Change visibility*.
2. Vào **Settings → Pages → Build and deployment → Source**, chọn **GitHub Actions**.
3. Push code lên. Sau khoảng 1–2 phút, trang sẽ có tại https://hoaibaok19-cmd.github.io/BlazorApp1/.

Workflow tự xử lý các việc sau:

- Đặt `<base href>` đúng theo tên repo: dùng `/<repo>/` cho project site, và `/` cho repo `<username>.github.io` hoặc khi có file `wwwroot/CNAME` (custom domain).
- Tạo `404.html` để các đường dẫn sâu vẫn mở được app.
- Tạo `.nojekyll` để GitHub Pages phục vụ thư mục `_framework`.

## Credits

- Giao diện dựa trên template portfolio Blazor WebAssembly song ngữ (NPL Portfolio).
- Icons: [Feather Icons](https://feathericons.com) (MIT License)
- Fonts: [Playfair Display](https://fonts.google.com/specimen/Playfair+Display) và [Be Vietnam Pro](https://fonts.google.com/specimen/Be+Vietnam+Pro) (SIL Open Font License)
