using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace EFEntity
{
    public class HRDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HR_DB;User ID=sa;Password=123;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //写对应的配置信息
            var bonus = modelBuilder.Entity<Bonus>();
            bonus.ToTable(nameof(Bonus));
            bonus.HasKey("bon_id");

            var cffk = modelBuilder.Entity<Config_file_first_kind>();
            cffk.ToTable(nameof(Config_File_First_Kind));
            cffk.HasKey("ffk_id");

            var cfsk = modelBuilder.Entity<Config_file_second_kind>();
            cfsk.ToTable(nameof(Config_File_Second_Kind));
            cfsk.HasKey("fsk_id");

            var cftk = modelBuilder.Entity<Config_file_third_kind>();
            cftk.ToTable(nameof(Config_File_Third_Kind));
            cftk.HasKey("ftk_id");

            var cm = modelBuilder.Entity<Config_major>();
            cm.ToTable(nameof(Config_major));
            cm.HasKey("mak_id");

            var cmk = modelBuilder.Entity<Config_major_kind>();
            cmk.ToTable(nameof(Config_major_kind));
            cmk.HasKey("mfk_id");

            var cpc = modelBuilder.Entity<Config_public_char>();
            cpc.ToTable(nameof(Config_public_char));
            cpc.HasKey("pbc_id");

            var cpk = modelBuilder.Entity<Config_primary_key>();
            cpk.ToTable(nameof(Config_primary_key));
            cpk.HasKey("prk_id");

            var cqfk = modelBuilder.Entity<Config_question_first_kind>();
            cqfk.ToTable(nameof(Config_question_first_kind));
            cqfk.HasKey("qfk_id");

            var cqsk = modelBuilder.Entity<Config_question_second_kind>();
            cqsk.ToTable(nameof(Config_question_second_kind));
            cqsk.HasKey("qsk_id");

            var ea = modelBuilder.Entity<Engage_answer>();
            ea.ToTable(nameof(Engage_answer));
            ea.HasKey("ans_id");

            var ead = modelBuilder.Entity<Engage_answer_details>();
            ead.ToTable(nameof(Engage_answer_details));
            ead.HasKey("and_id");

            var ee = modelBuilder.Entity<Engage_exam>();
            ee.ToTable(nameof(Engage_exam));
            ee.HasKey("exa_id");

            var eed = modelBuilder.Entity<Engage_exam_details>();
            eed.ToTable(nameof(Engage_exam_details));
            eed.HasKey("exd_id");

            var ei = modelBuilder.Entity<Engage_interview>();
            ei.ToTable(nameof(Engage_interview));
            ei.HasKey("ein_id");


            var emr = modelBuilder.Entity<Engage_major_release>();
            emr.ToTable(nameof(Engage_major_release));
            emr.HasKey("mre_id");

            var er = modelBuilder.Entity<Engage_resume>();
            er.ToTable(nameof(Engage_resume));
            er.HasKey("res_id");

            var es = modelBuilder.Entity<Engage_subjects>();
            es.ToTable(nameof(Engage_subjects));
            es.HasKey("sub_id");

            var hf = modelBuilder.Entity<Human_file>();
            hf.ToTable(nameof(Human_file));
            hf.HasKey("huf_id");

            var hfd = modelBuilder.Entity<HumanFile_dig>();
            hfd.ToTable(nameof(HumanFile_dig));
            hfd.HasKey("hfd_id");


            var mc = modelBuilder.Entity<Major_change>();
            mc.ToTable(nameof(Major_change));
            mc.HasKey("mch_id");

            var sg = modelBuilder.Entity<Salary_grant>();
            sg.ToTable(nameof(Salary_grant));
            sg.HasKey("sgr_id");


            var sgd = modelBuilder.Entity<Salary_grant_details>();
            sgd.ToTable(nameof(Salary_grant_details));
            sgd.HasKey("grd_id");

            var ss = modelBuilder.Entity<Salary_standard>();
            ss.ToTable(nameof(Salary_standard));
            ss.HasKey("ssd_id");

            var ssd = modelBuilder.Entity<Salary_standard_details>();
            ssd.ToTable(nameof(Salary_standard_details));
            ssd.HasKey("sdt_id");

            var t = modelBuilder.Entity<Training>();
            t.ToTable(nameof(Training));
            t.HasKey("tra_id");

            var u = modelBuilder.Entity<Users>();
            u.ToTable(nameof(Users));
            u.HasKey("user_id");
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Config_public_char> Config_public_char { get; set; }
        public DbSet<Config_file_first_kind> Config_File_First_Kind { get; set; }
        public DbSet<Config_file_second_kind> Config_File_Second_Kind { get; set; }
        public DbSet<Config_file_third_kind> Config_File_Third_Kind { get; set; }
        public DbSet<Config_question_first_kind> Config_question_first_kind { get; set; }
        public DbSet<Config_question_second_kind> Config_question_second_kind { get; set; }
        public DbSet<Config_primary_key> Config_primary_key { get; set; }
        public DbSet<Config_major_kind> Config_major_kind { get; set; }
        public DbSet<Config_major> Config_major { get; set; }
        public DbSet<Human_file> Human_file { get; set; }
        public DbSet<HumanFile_dig> HumanFile_dig { get; set; }
        public DbSet<Salary_standard_details> Salary_standard_details { get; set; }
        public DbSet<Salary_standard> Salary_standard { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Major_change> Major_change { get; set; }
        public DbSet<Salary_grant> Salary_grant { get; set; }
        public DbSet<Salary_grant_details> Salary_grant_details { get; set; }
        public DbSet<Engage_major_release> Engage_major_release { get; set; }
        public DbSet<Engage_exam_details> Engage_exam_details { get; set; }
        public DbSet<Engage_exam> Engage_exam { get; set; }
        public DbSet<Engage_answer> Engage_answer { get; set; }
        public DbSet<Engage_answer_details> Engage_answer_details { get; set; }
        public DbSet<Engage_subjects> Engage_subjects { get; set; }
        public DbSet<Engage_resume> Engage_resume { get; set; }
        public DbSet<Engage_interview> Engage_interview { get; set; }
    }
}
