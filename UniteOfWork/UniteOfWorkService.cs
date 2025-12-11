using Relations.Models;
using Relations.Services;

namespace Relations.UniteOfWork;

public class UniteOfWorkService
{
    public AdminUserService OldAdminUserService { get; set; }
    public GenericService<AdminUser> AdminUserService { get;}
    public GenericService<Assistant> AssistantService { get;}
    public GenericService<Curator> CuratorService { get;}
    public GenericService<Dean> DeanService { get;}
    public GenericService<Faculty> FacultyService { get;}
    public GenericService<Group> GroupService { get;}
    public GenericService<GroupCurator> GroupCuratorService { get;}
    public GenericService<GroupLecture> GroupLectureService { get;}
    public GenericService<Head> HeadService { get;}
    public GenericService<Lecture> LectureService { get;}
    public GenericService<LectureRoom> LectureRoomService { get;}
    public GenericService<Schedule> ScheduleService { get;}
    public GenericService<Subject> SubjectService { get;}
    public GenericService<Teacher> TeacherService { get;}


    public UniteOfWorkService()
    {
        AdminUserService = new GenericService<AdminUser>();
        AssistantService = new GenericService<Assistant>();
        CuratorService = new GenericService<Curator>();
        OldAdminUserService = new AdminUserService();
        DeanService = new GenericService<Dean>();
        FacultyService = new GenericService<Faculty>();
        GroupService = new GenericService<Group>();
        GroupCuratorService = new GenericService<GroupCurator>();
        GroupLectureService = new GenericService<GroupLecture>();
        HeadService = new GenericService<Head>();
        LectureService = new GenericService<Lecture>();
        ScheduleService = new GenericService<Schedule>();
        SubjectService = new GenericService<Subject>();
        TeacherService = new GenericService<Teacher>();
        LectureRoomService = new GenericService<LectureRoom>();
    }
}
