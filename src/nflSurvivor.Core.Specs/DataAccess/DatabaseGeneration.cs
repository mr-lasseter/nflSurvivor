using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using NflSurvivior.Core.Infrastructure.NHibernate;
using nflSurvivior.Core.Domain;

namespace nflSurvivor.Core.Specs.DataAccess
{

    [TestFixture, Explicit]
    public class DatabaseGeneration
    {
        private Configuration _configuration;
        private ISessionFactory _sessionFactory;

        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            _configuration = NHibernateConfiguration.Configure("thread_static");
            _sessionFactory = _configuration.BuildSessionFactory();
        }
        
        [SetUp]
        public void Setup()
        {
            CurrentSessionContext.Bind(_sessionFactory.OpenSession());
        }

        [TearDown]
        public void TearDown()
        {
            var session = CurrentSessionContext.Unbind(_sessionFactory);
            session.Close();
            session.Dispose();
        }

        [Test]
        public void Create_the_database()
        {
            var export = new SchemaExport(_configuration);
            export.Create(true, true);
            StageTeams();
        }

        public void StageTeams()
        {
            var teams = new List<Team>();

            teams.Add(new Team {EspnTeamName = "Oakland", Location = "Oakland", Mascot = "Raiders"});   
            teams.Add(new Team {EspnTeamName = "San Diego", Location = "San Diego", Mascot = "Chargers"});   
            teams.Add(new Team {EspnTeamName = "New Orleans", Location = "New Orleans", Mascot = "Saints"});   
            teams.Add(new Team {EspnTeamName = "Atlanta", Location = "Atlanta", Mascot = "Falcons"});   
            teams.Add(new Team {EspnTeamName = "Pittsburgh", Location = "Pittsburgh", Mascot = "Steelers"});   
            teams.Add(new Team {EspnTeamName = "Cincinnati", Location = "Cincinnati", Mascot = "Bengals"});   
            teams.Add(new Team {EspnTeamName = "St. Louis", Location = "St. Louis", Mascot = "Rams"});   
            teams.Add(new Team {EspnTeamName = "Cleveland", Location = "Cleveland", Mascot = "Browns"});   
            teams.Add(new Team {EspnTeamName = "Buffalo", Location = "Buffalo", Mascot = "Bills"});   
            teams.Add(new Team {EspnTeamName = "Dallas", Location = "Dallas", Mascot = "Cowboys"});   
            teams.Add(new Team {EspnTeamName = "Jacksonville", Location = "Jacksonville", Mascot = "Jaguars"});   
            teams.Add(new Team {EspnTeamName = "Indianapolis", Location = "Indianapolis", Mascot = "Colts"});   
            teams.Add(new Team {EspnTeamName = "Denver", Location = "Denver", Mascot = "Broncos"});   
            teams.Add(new Team {EspnTeamName = "Kansas City", Location = "Kansas City", Mascot = "Cheifs"});   
            teams.Add(new Team {EspnTeamName = "Washington", Location = "Washington", Mascot = "Redskins"});   
            teams.Add(new Team {EspnTeamName = "Miami", Location = "Miami", Mascot = "Dolphins"});   
            teams.Add(new Team {EspnTeamName = "Arizona", Location = "Arizona", Mascot = "Cardinals"});   
            teams.Add(new Team {EspnTeamName = "Philadelphia", Location = "Philadelphia", Mascot = "Eagles"});   
            teams.Add(new Team {EspnTeamName = "Houston", Location = "Houston", Mascot = "Texans"});   
            teams.Add(new Team {EspnTeamName = "Tampa Bay", Location = "Tampa Bay", Mascot = "Buccaneers"});   
            teams.Add(new Team {EspnTeamName = "Tennessee", Location = "Tennessee", Mascot = "Titans"});   
            teams.Add(new Team {EspnTeamName = "Carolina", Location = "Carolina", Mascot = "Panthers"});   
            teams.Add(new Team {EspnTeamName = "Baltimore", Location = "Baltimore", Mascot = "Ravens"});   
            teams.Add(new Team {EspnTeamName = "Seattle", Location = "Seattle", Mascot = "Seahawks"});   
            teams.Add(new Team {EspnTeamName = "Detroit", Location = "Detroit", Mascot = "Lions"});   
            teams.Add(new Team {EspnTeamName = "Chicago", Location = "Chicago", Mascot = "Bears"});   
            teams.Add(new Team {EspnTeamName = "NY Giants", Location = "New York", Mascot = "Giants"});   
            teams.Add(new Team {EspnTeamName = "San Francisco", Location = "San Francisco", Mascot = "49ers"});   
            teams.Add(new Team {EspnTeamName = "New England", Location = "New England", Mascot = "Patriots"});   
            teams.Add(new Team {EspnTeamName = "NY Jets", Location = "New York", Mascot = "Jets"});   
            teams.Add(new Team {EspnTeamName = "Minnesota", Location = "Minnesota", Mascot = "Vikings"});   
            teams.Add(new Team {EspnTeamName = "Green Bay", Location = "Green Bay", Mascot = "Packers"});

            var session = _sessionFactory.OpenSession();
            teams.ForEach(session.SaveOrUpdate);
            session.Flush();
        }
    }
}