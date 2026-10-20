namespace BlazorApp1.Services;

/// <summary>Interface labels (buttons, headings…) in English and Vietnamese. Personal content lives in wwwroot/data/portfolio.json.</summary>
public static class UiText
{
    private static readonly Dictionary<string, (string En, string Vi)> Strings = new()
    {
        ["nav.home"] = ("Home", "Trang chủ"),
        ["nav.gallery"] = ("Gallery", "Thư viện"),
        ["nav.about"] = ("About", "Giới thiệu"),
        ["nav.skills"] = ("Services", "Dịch vụ"),
        ["nav.experience"] = ("Experience", "Kinh nghiệm"),
        ["nav.contact"] = ("Contact", "Liên hệ"),
        ["nav.primary"] = ("Main navigation", "Điều hướng chính"),
        ["nav.skip"] = ("Skip to content", "Bỏ qua đến nội dung"),
        ["nav.open"] = ("Open menu", "Mở menu"),
        ["nav.close"] = ("Close menu", "Đóng menu"),
        ["lang.switch"] = ("Chuyển sang tiếng Việt", "Switch to English"),
        ["theme.light"] = ("Switch to light theme", "Chuyển sang giao diện sáng"),
        ["theme.dark"] = ("Switch to dark theme", "Chuyển sang giao diện tối"),
        ["social"] = ("Social links", "Mạng xã hội"),

        ["hero.greeting"] = ("Photographer", "Nhiếp ảnh gia"),
        ["hero.viewWork"] = ("View gallery", "Xem thư viện"),
        ["hero.contact"] = ("Get in touch", "Liên hệ đặt lịch"),
        ["hero.cv"] = ("Download CV", "Tải CV"),
        ["hero.scroll"] = ("Scroll down", "Cuộn xuống"),

        ["about.title"] = ("Behind the lens", "Phía sau ống kính"),
        ["about.subtitle"] = ("Who I am, how I see light and what I love to photograph.", "Tôi là ai, tôi cảm nhận ánh sáng ra sao và tôi yêu thích chụp điều gì."),

        ["skills.title"] = ("What I offer", "Dịch vụ của tôi"),
        ["skills.subtitle"] = ("From the first shutter click to the final edit — here's how I can help tell your story.", "Từ cú bấm máy đầu tiên đến khâu hậu kỳ cuối cùng — đây là cách tôi giúp kể câu chuyện của bạn."),
        ["skills.toolbox"] = ("In my camera bag", "Thiết bị trong túi máy"),
        ["skills.level.expert"] = ("Expert", "Chuyên sâu"),
        ["skills.level.advanced"] = ("Advanced", "Nâng cao"),
        ["skills.level.intermediate"] = ("Intermediate", "Khá"),
        ["skills.level.familiar"] = ("Familiar", "Cơ bản"),

        ["experience.title"] = ("My journey so far", "Hành trình của tôi"),
        ["experience.subtitle"] = ("Exhibitions, collaborations and studies that shaped my eye.", "Những triển lãm, dự án hợp tác và quá trình học tập đã rèn giũa con mắt của tôi."),
        ["experience.work"] = ("Work", "Công việc"),
        ["experience.education"] = ("Education", "Học vấn"),

        ["gallery.title"] = ("Selected work", "Tuyển tập ảnh"),
        ["gallery.subtitle"] = ("A living collection of frames — portraits, weddings, streets and landscapes. Tap any photo to view it full-size.", "Bộ sưu tập những khoảnh khắc — chân dung, ảnh cưới, đời thường và phong cảnh. Chạm vào ảnh để xem ở kích thước đầy đủ."),
        ["gallery.all"] = ("All", "Tất cả"),
        ["gallery.filter"] = ("Filter photos", "Lọc ảnh"),
        ["gallery.view"] = ("View photo", "Xem ảnh"),
        ["gallery.viewer"] = ("Image viewer", "Trình xem ảnh"),
        ["gallery.close"] = ("Close", "Đóng"),
        ["gallery.prev"] = ("Previous photo", "Ảnh trước"),
        ["gallery.next"] = ("Next photo", "Ảnh sau"),

        ["contact.title"] = ("Let's create something beautiful", "Cùng tạo nên điều đẹp đẽ"),
        ["contact.subtitle"] = ("Booking a session, planning a shoot or just want to say hello? I'd love to hear from you.", "Bạn muốn đặt lịch chụp, lên kế hoạch cho buổi chụp hay chỉ muốn chào hỏi? Rất mong được nghe từ bạn."),
        ["contact.email"] = ("Email", "Email"),
        ["contact.phone"] = ("Phone", "Điện thoại"),
        ["contact.location"] = ("Location", "Địa điểm"),
        ["contact.copy"] = ("Copy email address", "Sao chép địa chỉ email"),
        ["contact.copied"] = ("Copied!", "Đã sao chép!"),
        ["contact.form.title"] = ("Send me a message", "Gửi lời nhắn cho tôi"),
        ["contact.form.name"] = ("Your name", "Họ và tên"),
        ["contact.form.email"] = ("Your email", "Email của bạn"),
        ["contact.form.message"] = ("Message", "Lời nhắn"),
        ["contact.form.namePlaceholder"] = ("Jane Doe", "Nguyễn Văn A"),
        ["contact.form.messagePlaceholder"] = ("Tell me about your shoot — date, location and what you have in mind…", "Chia sẻ về buổi chụp của bạn — ngày, địa điểm và ý tưởng bạn mong muốn…"),
        ["contact.form.send"] = ("Send message", "Gửi lời nhắn"),
        ["contact.form.sending"] = ("Sending…", "Đang gửi…"),
        ["contact.form.sent"] = ("Thank you! Your message has been sent.", "Cảm ơn bạn! Lời nhắn đã được gửi."),
        ["contact.form.opened"] = ("Opening your email app…", "Đang mở ứng dụng email của bạn…"),
        ["contact.form.error"] = ("Something went wrong. Please email me directly.", "Đã có lỗi xảy ra. Vui lòng gửi email trực tiếp cho tôi."),
        ["contact.form.required"] = ("Please fill in every field.", "Vui lòng điền đầy đủ các trường."),
        ["contact.form.invalidEmail"] = ("Please enter a valid email address.", "Vui lòng nhập địa chỉ email hợp lệ."),
        ["contact.form.mailtoNote"] = ("Your email app will open with the message pre-filled.", "Ứng dụng email sẽ mở với nội dung đã được điền sẵn."),

        ["footer.rights"] = ("All rights reserved.", "Bảo lưu mọi quyền."),
        ["footer.built"] = ("Built with Blazor WebAssembly · Hosted on GitHub Pages", "Xây dựng bằng Blazor WebAssembly · Triển khai trên GitHub Pages"),
        ["footer.top"] = ("Back to top", "Lên đầu trang"),

        ["notfound.title"] = ("Page not found", "Không tìm thấy trang"),
        ["notfound.text"] = ("The page you're looking for doesn't exist or has been moved.", "Trang bạn đang tìm không tồn tại hoặc đã được di chuyển."),
        ["notfound.home"] = ("Back to home", "Về trang chủ"),

        ["error.title"] = ("Couldn't load the portfolio content", "Không thể tải nội dung portfolio"),
        ["error.text"] = ("Check that wwwroot/data/portfolio.json exists and contains valid JSON.", "Hãy kiểm tra file wwwroot/data/portfolio.json có tồn tại và đúng định dạng JSON."),
        ["error.reload"] = ("Reload", "Tải lại"),
    };

    public static string Get(string key, string language) =>
        Strings.TryGetValue(key, out var text) ? (language == "vi" ? text.Vi : text.En) : key;
}
