# Bao Truong — Portfolio

Website portfolio cá nhân của **Bao Truong**, gộp **ba chuyên môn** vào một trang, mỗi chuyên môn có phong cách riêng:

- 🧱 **BIM** — BIM Modeler (Revit, Navisworks, Dynamo). Tông xanh blueprint, font kỹ thuật, có mục **Dự án**.
- ⛰️ **Trekking** — Hướng dẫn viên trekking. Tông đất/rừng ấm, font serif Fraunces, có **Thư viện hành trình**.
- 📷 **Photography** — Nhiếp ảnh gia. Tông vàng ấm, font serif Playfair, có **Thư viện ảnh**.

Trang mở đầu bằng **màn hình chọn chuyên môn** (3 thẻ); chọn một thẻ sẽ vào portfolio tương ứng với theme riêng. Có thể đổi lại bất cứ lúc nào bằng nút lưới ⊞ trên thanh menu, hoặc mở thẳng bằng `?p=bim`, `?p=trekking`, `?p=photography`. Trang web được viết bằng **Blazor WebAssembly (.NET 10)** và tự động deploy lên **GitHub Pages** bằng GitHub Actions.

🔗 **Live:** https://hoaibaok19-cmd.github.io/BlazorApp1/

## ✅ Việc cần làm trước khi công khai

Nội dung hiện tại là **bản nháp**: chữ đã viết theo từng vai trò, còn ảnh là ảnh mẫu ngẫu nhiên từ picsum.photos. Mỗi chuyên môn có một file nội dung riêng trong `BlazorApp1/wwwroot/data/`:

- [`portfolio.bim.json`](BlazorApp1/wwwroot/data/portfolio.bim.json) — nội dung BIM (dùng mục `projects`)
- [`portfolio.trekking.json`](BlazorApp1/wwwroot/data/portfolio.trekking.json) — nội dung trekking (dùng mục `gallery`)
- [`portfolio.photography.json`](BlazorApp1/wwwroot/data/portfolio.photography.json) — nội dung nhiếp ảnh (dùng mục `gallery`)

Mở từng file, tìm các dòng `// TODO` và thay bằng đồ thật:

- [ ] **Ảnh thật của bạn** — chép vào `BlazorApp1/wwwroot/images/` rồi thay các link `picsum.photos` trong `gallery`/`projects` và `profile.heroImage`
- [ ] Họ tên đầy đủ có dấu (`profile.name`)
- [ ] Email cá nhân (`profile.email` và mục `Email` trong `socials`)
- [ ] Link mạng xã hội / LinkedIn / GitHub (`socials`)
- [ ] Địa điểm, năm kinh nghiệm, số liệu ở `stats`
- [ ] Danh sách công cụ/thiết bị trong `toolbox`

## Tính năng

- **Màn hình chọn chuyên môn** mở đầu: 3 thẻ BIM / Trekking / Photography, mỗi thẻ preview màu và font riêng; đổi lại bất cứ lúc nào bằng nút ⊞ trên menu.
- **Mỗi chuyên môn một theme riêng** (màu thương hiệu, gradient, font) — tự đổi theo lựa chọn, dùng CSS variables theo `data-persona`.
- Trang one-page gồm Hero toàn màn hình, phần trưng bày (**Dự án** cho BIM hoặc **Thư viện ảnh** cho trekking/nhiếp ảnh), Giới thiệu, Dịch vụ/Kỹ năng, Kinh nghiệm và Liên hệ.
- **Thư viện ảnh dạng masonry** với bộ lọc theo thể loại và **lightbox** (bấm ảnh, chuyển bằng ◀ ▶ hoặc ← →, đóng bằng Esc); **mục Dự án** có thẻ dự án và hộp thoại chi tiết.
- Song ngữ **English / Tiếng Việt**: có nút chuyển ngôn ngữ, lần đầu vào trang sẽ tự chọn theo ngôn ngữ của trình duyệt.
- Giao diện **Dark / Light**: lần đầu theo hệ điều hành, lựa chọn sau đó được lưu trong `localStorage`.
- **Toàn bộ nội dung mỗi chuyên môn nằm trong một file JSON** nên không cần sửa code khi cập nhật.
- Hiệu ứng reveal khi cuộn trang, scroll-spy trên thanh menu, form liên hệ.
- Responsive cho mobile, tablet và desktop; hỗ trợ accessibility (skip link, điều hướng bằng bàn phím, `prefers-reduced-motion`).
- Có trang 404 riêng. Deep link (ví dụ `/?p=bim#projects`) hoạt động trên GitHub Pages.

## Cấu trúc thư mục

```
.github/workflows/deploy.yml   # CI/CD: build và deploy lên GitHub Pages
BlazorApp1/
├── wwwroot/
│   ├── data/
│   │   ├── portfolio.bim.json          # ⭐ NỘI DUNG BIM
│   │   ├── portfolio.trekking.json     # ⭐ NỘI DUNG TREKKING
│   │   └── portfolio.photography.json  # ⭐ NỘI DUNG NHIẾP ẢNH
│   ├── images/                # Ảnh của bạn (tự tạo khi thêm ảnh)
│   ├── css/app.css            # Design system + theme theo persona
│   ├── js/site.js             # Persona, scroll-spy, reveal, dialog, clipboard
│   └── index.html             # Trang khung, màn hình loading, meta SEO
├── Sections/                  # Hero, Projects, Gallery, About, Skills, Experience, Contact
├── Components/                # PersonaChooser, Icon, Lightbox, ProjectCard, ... dùng chung
├── Layout/                    # MainLayout, NavBar, SiteFooter
├── Services/
│   ├── SiteState.cs           # Persona, ngôn ngữ, theme, dữ liệu, section active
│   └── UiText.cs              # Nhãn giao diện EN/VI (chung + override theo persona)
└── Models/                    # Schema của các file portfolio.*.json
```

## ✏️ Chỉnh sửa nội dung

Mỗi chuyên môn có một file riêng trong `wwwroot/data/` (`portfolio.bim.json`, `portfolio.trekking.json`, `portfolio.photography.json`) nhưng **chung một cấu trúc**. BIM dùng mục `projects`; trekking và nhiếp ảnh dùng mục `gallery` — mục nào để trống (`[]`) thì tự ẩn. Tên các chuyên môn và nhãn trên màn hình chọn nằm ở `Services/UiText.cs` (khóa `chooser.*`).

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
| `projects` | (BIM) Mỗi dự án gồm `id`, `title`, `category` (bộ lọc), `summary`, `description`, `highlights`, `tags`, `icon`, `image` (không bắt buộc — thiếu thì hiện bìa tạo sẵn), `year`, `repoUrl`, `demoUrl`, `featured` |
| `gallery` | Mỗi ảnh gồm `id`, `image` (ảnh phóng to), `thumb` (ảnh nhỏ cho lưới — không bắt buộc), `title`, `category` (dùng làm bộ lọc), `caption`, `location`, `year`, `featured` (ô lớn) |
| `contact` | `heading`, `text` (không bắt buộc) và `formspreeId` |

Muốn ẩn một section thì để trống dữ liệu của nó, ví dụ `"gallery": []` hoặc `"projects": []`. Section đó và mục menu tương ứng sẽ tự ẩn.

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

`activity` `alert-circle` `arrow-right` `arrow-up` `arrow-up-right` `award` `bar-chart` `book` `book-open` `box` `briefcase` `calendar` `camera` `check` `check-circle` `clipboard` `cloud` `code` `coffee` `compass` `copy` `cpu` `crosshair` `database` `download` `external-link` `facebook` `file-text` `folder` `git-branch` `github` `globe` `grid` `heart` `home` `info` `instagram` `layers` `layout` `linkedin` `mail` `map` `map-pin` `menu` `message-circle` `monitor` `moon` `mountain` `navigation` `package` `pen-tool` `phone` `send` `server` `shield` `smartphone` `star` `sun` `sunrise` `target` `tent` `terminal` `thermometer` `tool` `tree` `trending-up` `twitter` `user` `users` `wind` `x` `youtube` `zap`

Muốn thêm icon khác: copy phần nội dung bên trong thẻ `<svg>` từ feathericons.com vào `Components/IconPaths.cs`.

### Form liên hệ

- **Mặc định** (`formspreeId` để trống): khi gửi form, trang sẽ mở ứng dụng email của người xem và điền sẵn nội dung.
- **Gửi trực tiếp**: tạo form miễn phí tại [formspree.io](https://formspree.io), rồi điền ID của form (ví dụ `"xyzabcd"`) vào `contact.formspreeId`.

### Nhãn giao diện, màu sắc và favicon

- Chữ trên menu, nút bấm và thông báo nằm trong `Services/UiText.cs` (nhãn chung + phần override theo persona).
- Màu thương hiệu, gradient và font được khai báo bằng CSS variables ở đầu `wwwroot/css/app.css`; mỗi persona override lại các biến này trong khối `:root[data-persona="…"]`.
- Favicon nằm ở `wwwroot/favicon.svg` (chữ `BT`); `favicon.png` và `icon-192.png` là bản PNG của cùng biểu tượng.
- Tiêu đề trang, mô tả SEO và chữ trên màn hình loading nằm trong `wwwroot/index.html`.

## 💻 Chạy trên máy

Cần cài [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
cd BlazorApp1
dotnet watch
```

Sau đó mở http://localhost:5231. Mỗi khi sửa một file `portfolio.*.json`, chỉ cần tải lại trang để thấy thay đổi.

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
- Fonts: [Playfair Display](https://fonts.google.com/specimen/Playfair+Display), [Fraunces](https://fonts.google.com/specimen/Fraunces), [Space Grotesk](https://fonts.google.com/specimen/Space+Grotesk), [JetBrains Mono](https://fonts.google.com/specimen/JetBrains+Mono) và [Be Vietnam Pro](https://fonts.google.com/specimen/Be+Vietnam+Pro) (SIL Open Font License)
