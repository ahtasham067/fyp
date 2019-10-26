USE [master]
GO
/****** Object:  Database [FYP]    Script Date: 26-Oct-19 2:19:36 PM ******/
CREATE DATABASE [FYP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FYP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FYP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FYP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FYP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FYP] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FYP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FYP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FYP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FYP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FYP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FYP] SET ARITHABORT OFF 
GO
ALTER DATABASE [FYP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FYP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FYP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FYP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FYP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FYP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FYP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FYP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FYP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FYP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FYP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FYP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FYP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FYP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FYP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FYP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FYP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FYP] SET RECOVERY FULL 
GO
ALTER DATABASE [FYP] SET  MULTI_USER 
GO
ALTER DATABASE [FYP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FYP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FYP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FYP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FYP] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FYP', N'ON'
GO
ALTER DATABASE [FYP] SET QUERY_STORE = OFF
GO
USE [FYP]
GO
/****** Object:  Table [dbo].[AlliedField]    Script Date: 26-Oct-19 2:19:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlliedField](
	[AlliedFieldId] [int] IDENTITY(1,1) NOT NULL,
	[AlliedFieldName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AlliedField] PRIMARY KEY CLUSTERED 
(
	[AlliedFieldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Batch]    Script Date: 26-Oct-19 2:19:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Batch](
	[BatchId] [int] IDENTITY(1,1) NOT NULL,
	[BatchName] [varchar](50) NOT NULL,
	[StudentLoginId] [int] NULL,
	[StudentSignUpId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BatchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Campus]    Script Date: 26-Oct-19 2:19:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campus](
	[CampusId] [int] IDENTITY(1,1) NOT NULL,
	[CampusName] [varchar](50) NOT NULL,
	[StudentLoginId] [int] NULL,
	[StudentSignUpId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CampusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Co_Supervisor]    Script Date: 26-Oct-19 2:19:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Co_Supervisor](
	[CoSupervisorId] [int] IDENTITY(1,1) NOT NULL,
	[CoSupervisorName] [varchar](50) NOT NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CoSupervisorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domain]    Script Date: 26-Oct-19 2:19:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domain](
	[DomainId] [int] IDENTITY(1,1) NOT NULL,
	[DomainName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Domain] PRIMARY KEY CLUSTERED 
(
	[DomainId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fyp_Idea]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fyp_Idea](
	[IdeaId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Domain] [int] NOT NULL,
	[AlliedField] [int] NOT NULL,
	[Summary] [text] NOT NULL,
	[IdeaFile] [varbinary](max) NULL,
	[TeacherSignUpId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdeaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Internal_Evaluation]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Internal_Evaluation](
	[InternalEvaluationId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ProjectTitle] [int] NOT NULL,
	[Supervisor] [int] NOT NULL,
	[CoSupervisor] [int] NOT NULL,
	[Scope] [varchar](50) NOT NULL,
	[Completion] [int] NOT NULL,
	[OverAllComments] [text] NULL,
	[EvaluationDate] [date] NOT NULL,
	[TeacherId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[InternalEvaluationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Internal_Evaluation_Student]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Internal_Evaluation_Student](
	[InternalEvaluationStudentId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[RegNo] [int] NOT NULL,
	[Documentation] [float] NOT NULL,
	[Implementation] [float] NOT NULL,
	[FypKnowledge] [float] NOT NULL,
	[PresentationOnSkill] [float] NOT NULL,
	[TotalMarks] [float] NOT NULL,
	[IndividualComments] [text] NOT NULL,
	[TeacherId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[InternalEvaluationStudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Program]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Program](
	[ProgramId] [int] IDENTITY(1,1) NOT NULL,
	[ProgramName] [varchar](50) NOT NULL,
	[StudentLoginId] [int] NULL,
	[StudentSignUpId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProgramId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Supervisor] [int] NOT NULL,
	[CoSupervisor] [int] NOT NULL,
	[Summary] [text] NOT NULL,
	[Objective] [text] NOT NULL,
	[Scope] [text] NOT NULL,
	[ToolsAndTechnologies] [text] NOT NULL,
	[ProposalFileType] [varchar](500) NULL,
	[ProposalFilePath] [varchar](500) NULL,
	[ProposalFileName] [varchar](500) NULL,
	[SrsFileType] [varchar](500) NULL,
	[SrsFilePath] [varchar](500) NULL,
	[SrsFileName] [varchar](500) NULL,
	[SreFileType] [varchar](500) NULL,
	[SreFilePath] [varchar](500) NULL,
	[SreFileName] [varchar](500) NULL,
	[CodeFileType] [varchar](500) NULL,
	[CodeFilePath] [varchar](500) NULL,
	[CodeFileName] [varchar](500) NULL,
	[PrototypeFileType] [varchar](500) NULL,
	[PrototypeFilePath] [varchar](500) NULL,
	[PrototypeFileName] [varchar](500) NULL,
	[FinalReportFileType] [varchar](500) NULL,
	[FinalReportFilePath] [varchar](500) NULL,
	[FinalReportFileName] [varchar](500) NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project_Student]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project_Student](
	[ProjectStudentId] [int] IDENTITY(1,1) NOT NULL,
	[Semester] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[ContactNo] [int] NOT NULL,
	[StudentName] [varchar](50) NOT NULL,
	[RegNo] [varchar](50) NOT NULL,
	[ProjectId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProjectStudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semester]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semester](
	[SemesterId] [int] IDENTITY(1,1) NOT NULL,
	[SemesterNumber] [int] NOT NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SemesterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Login]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Login](
	[StudentLoginId] [int] IDENTITY(1,1) NOT NULL,
	[Campus] [int] NOT NULL,
	[Batch] [int] NOT NULL,
	[Program] [int] NOT NULL,
	[RegNo] [int] NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Student_Login] PRIMARY KEY CLUSTERED 
(
	[StudentLoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_SignUp]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_SignUp](
	[StudentSignUpId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NOT NULL,
	[Campus] [int] NOT NULL,
	[Batch] [int] NOT NULL,
	[Program] [int] NOT NULL,
	[RegNo] [varchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](250) NOT NULL,
	[EmailVerification] [bit] NULL,
	[ActivetionCode] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Student_SignUp] PRIMARY KEY CLUSTERED 
(
	[StudentSignUpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supervisor]    Script Date: 26-Oct-19 2:19:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supervisor](
	[SupervisorId] [int] IDENTITY(1,1) NOT NULL,
	[SupervisorName] [varchar](50) NOT NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SupervisorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supervisor_Evaluation]    Script Date: 26-Oct-19 2:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supervisor_Evaluation](
	[SupervisorEvaluationId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ProjectTitle] [int] NOT NULL,
	[Supervisor] [int] NOT NULL,
	[CoSupervisor] [int] NOT NULL,
	[Scope] [varchar](50) NOT NULL,
	[Completion] [int] NOT NULL,
	[OverAllComments] [int] NULL,
	[EvaluationDate] [date] NOT NULL,
	[TeacherId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupervisorEvaluationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supervisor_Evaluation_Student]    Script Date: 26-Oct-19 2:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supervisor_Evaluation_Student](
	[SupervisorEvaluationStudentId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[RegNo] [int] NOT NULL,
	[Documentation] [float] NOT NULL,
	[Implementation] [float] NOT NULL,
	[FypKnowledge] [float] NOT NULL,
	[PresentationOnSkill] [float] NOT NULL,
	[OverAllContribution] [float] NOT NULL,
	[TotalMarks] [float] NOT NULL,
	[IndividualComments] [text] NOT NULL,
	[TeacherId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupervisorEvaluationStudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher_Login]    Script Date: 26-Oct-19 2:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_Login](
	[TeacherLoginId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[TeacherSignUpId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherLoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher_SignUp]    Script Date: 26-Oct-19 2:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_SignUp](
	[TeacherSignUpId] [int] IDENTITY(1,1) NOT NULL,
	[TFullName] [varchar](50) NOT NULL,
	[TeacherId] [varchar](50) NOT NULL,
	[TEmail] [nvarchar](50) NOT NULL,
	[TPassword] [nvarchar](250) NOT NULL,
	[TEmailVerification] [bit] NULL,
	[TActivetionCode] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Teacher_SignUp] PRIMARY KEY CLUSTERED 
(
	[TeacherSignUpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Batch]  WITH CHECK ADD FOREIGN KEY([StudentLoginId])
REFERENCES [dbo].[Student_Login] ([StudentLoginId])
GO
ALTER TABLE [dbo].[Batch]  WITH CHECK ADD FOREIGN KEY([StudentSignUpId])
REFERENCES [dbo].[Student_SignUp] ([StudentSignUpId])
GO
ALTER TABLE [dbo].[Campus]  WITH CHECK ADD FOREIGN KEY([StudentLoginId])
REFERENCES [dbo].[Student_Login] ([StudentLoginId])
GO
ALTER TABLE [dbo].[Campus]  WITH CHECK ADD FOREIGN KEY([StudentSignUpId])
REFERENCES [dbo].[Student_SignUp] ([StudentSignUpId])
GO
ALTER TABLE [dbo].[Co_Supervisor]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Co_Supervisor]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Fyp_Idea]  WITH CHECK ADD FOREIGN KEY([TeacherSignUpId])
REFERENCES [dbo].[Teacher_SignUp] ([TeacherSignUpId])
GO
ALTER TABLE [dbo].[Internal_Evaluation]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Internal_Evaluation_Student]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Program]  WITH CHECK ADD FOREIGN KEY([StudentLoginId])
REFERENCES [dbo].[Student_Login] ([StudentLoginId])
GO
ALTER TABLE [dbo].[Program]  WITH CHECK ADD FOREIGN KEY([StudentSignUpId])
REFERENCES [dbo].[Student_SignUp] ([StudentSignUpId])
GO
ALTER TABLE [dbo].[Project_Student]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Semester]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Supervisor]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Supervisor_Evaluation]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Supervisor_Evaluation_Student]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Teacher_Login]  WITH CHECK ADD FOREIGN KEY([TeacherSignUpId])
REFERENCES [dbo].[Teacher_SignUp] ([TeacherSignUpId])
GO
USE [master]
GO
ALTER DATABASE [FYP] SET  READ_WRITE 
GO
