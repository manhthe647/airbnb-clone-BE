using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace airbnb_clone_BE.Shared
{
    public enum PalaceTypeEnum: byte {
        A = 0, //Nhà
        B = 1, //Căn hộ
        E = 5, //Khách sạn
        C = 3, //Lâu đài
        D = 4, //Hang
        F = 6, //Lều vải
    }

    public enum AccommodationTypeEnum: byte
    {
        A = 0, // Toàn bộ nhà
        B = 1, // Một căn phòng
        C = 3, // Phòng chung
    }

    public enum PalaceTagEnum: byte
    {
        A = 0, // Yên bình
        B = 1, // Độc đáo
        C = 3, // Phù hợp cho gia đình
        E = 4, // Vị trí trung tâm
        F = 5, // Rộng rãi
    }


}
