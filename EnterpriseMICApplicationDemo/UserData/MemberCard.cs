using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Card of Member MIC
	/// </summary>
	public class MemberCard : Panel {
		private OpacityLabel fullName;
		private OpacityLinkLabel birthDay;
		private OpacityLabel number;
		private OpacityLinkLabel enterDate;
		private OpacityLinkLabel email;
		private OpacityLabel local;
		private OpacityLinkLabel city;
		private OpacityLinkLabel area;
		private OpacityLinkLabel godFather;

		private OpacityLabel birthDayLabel;
		private OpacityLabel enterDateLabel;
		private OpacityLabel emailLabel;
		private OpacityLabel localLabel;
		private OpacityLabel cityLabel;
		private OpacityLabel areaLabel;
		private OpacityLabel godFatherLabel;

		private Member member;

		private int size = Const.MEMBERCARD_SIZE;

		public MemberCard() {
			this.Size = new System.Drawing.Size(size, size);
			this.BorderStyle = BorderStyle.Fixed3D;
			this.BackColor = System.Drawing.Color.White;
		}

		public void ReturnSize() {
			this.Size = new System.Drawing.Size(size, size);
		}

		private string ifThereIsNotDate(DateTime date) {
			if (date.Year == 1) {
				return "Нет данных";
			}
			return date.ToString();
		}

		public void ClearControls() {
			this.Controls.Clear();
		}

        public void ChangeMember(Member m) {
            member = m;
            number.Text = "№" + member.Number.ToString();
            fullName.Text = member.FirstName + " " + member.LastName + " " + member.Family;
            birthDay.Text = ifThereIsNotDate(member.BDate);
            enterDate.Text = ifThereIsNotDate(member.EnterDate);
            email.Text = member.Email;
            local.Text = member.Local;
            city.Text = member.City;            
            if ( member.Area != "" ) {
                area.Text = member.Area;
            }
            godFather.Text = Program.Data.GetMICGodFather(member).Family + " " + Program.Data.GetMICGodFather(member).FirstName + " " + Program.Data.GetMICGodFather(member).LastName;            
        }

		public void PutMember(Member m) {
			member = m;
			number = new OpacityLabel();
			number.Size = new System.Drawing.Size(100, 30);
			number.Text = "№";
			number.Text += member.Number.ToString();
			number.Location = new System.Drawing.Point(this.Width - number.Width);
			number.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			number.BorderStyle = BorderStyle.Fixed3D;
			this.Controls.Add(number);

			fullName = new OpacityLabel();
			fullName.Text = member.FirstName + " " + member.LastName + " " + member.Family;
			fullName.Size = new System.Drawing.Size(400, 30);
			fullName.Location = new System.Drawing.Point(0, 0);
			fullName.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(fullName);

			birthDayLabel = new OpacityLabel();
			birthDayLabel.Text = "День рождения";
			birthDayLabel.Location = new System.Drawing.Point(0, 40);
			birthDayLabel.Size = new System.Drawing.Size(180, 30);
			birthDayLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(birthDayLabel);

			birthDay = new OpacityLinkLabel();
			birthDay.Text = ifThereIsNotDate(member.BDate);
			birthDay.Size = new System.Drawing.Size(200, 30);
			birthDay.Click += new EventHandler(birthDay_Click);
			birthDay.Location = new System.Drawing.Point(200, 40);
			birthDay.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(birthDay);

			enterDateLabel = new OpacityLabel();
			enterDateLabel.Size = new System.Drawing.Size(190, 30);
			enterDateLabel.Location = new System.Drawing.Point(0, 80);
			enterDateLabel.Text = "Дата вступления";
			enterDateLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(enterDateLabel);

			enterDate = new OpacityLinkLabel();
			enterDate.Size = new System.Drawing.Size(200, 30);
			enterDate.Text = ifThereIsNotDate(member.EnterDate);
			enterDate.Click += new EventHandler(enterDate_Click);
			enterDate.Location = new System.Drawing.Point(200, 80);
			enterDate.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(enterDate);

			emailLabel = new OpacityLabel();
			emailLabel.Size = new System.Drawing.Size(190, 30);
			emailLabel.Location = new System.Drawing.Point(0, 120);
			emailLabel.Text = "E-mail";
			emailLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(emailLabel);

			email = new OpacityLinkLabel();
			email.Size = new System.Drawing.Size(200, 30);
			email.Text = member.Email;
			email.Location = new System.Drawing.Point(200, 120);
			email.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(email);

			local = new OpacityLabel();
			local.Size = new System.Drawing.Size(300, 60);
			local.Text = member.Local;
			local.Location = new System.Drawing.Point(200, 160);
			local.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(local);

			localLabel = new OpacityLabel();
			localLabel.Size = new System.Drawing.Size(200, 30);
			localLabel.Location = new System.Drawing.Point(0, 160);
			localLabel.Text = "Подразделение";
			localLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(localLabel);

			city = new OpacityLinkLabel();
			city.Size = new System.Drawing.Size(350, 30);
			city.Click += new EventHandler(city_Click);
			city.Location = new System.Drawing.Point(200, 240);
			city.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			city.Text = member.City;
			this.Controls.Add(city);

			cityLabel = new OpacityLabel();
			cityLabel.Size = new System.Drawing.Size(200, 30);
			cityLabel.Location = new System.Drawing.Point(0, 240);
			cityLabel.Text = "Населённый пункт";
			cityLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(cityLabel);

			if (member.Area != "") {
				area = new OpacityLinkLabel();
				area.Size = new System.Drawing.Size(350, 30);
				area.Location = new System.Drawing.Point(200, 280);
				area.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				area.Text = member.Area;
				this.Controls.Add(area);

				areaLabel = new OpacityLabel();
				areaLabel.Size = new System.Drawing.Size(200, 30);
				areaLabel.Location = new System.Drawing.Point(0, 280);
				areaLabel.Text = "Район";
				areaLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				this.Controls.Add(areaLabel);
			}

			godFather = new OpacityLinkLabel();
			godFather.Size = new System.Drawing.Size(300, 60);
			godFather.Location = new System.Drawing.Point(200, 320);
			godFather.Click += new EventHandler(godFather_Click);
			godFather.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			godFather.Text = Program.Data.GetMICGodFather(member).Family + " " + Program.Data.GetMICGodFather(member).FirstName + " " + Program.Data.GetMICGodFather(member).LastName;
			this.Controls.Add(godFather);

			godFatherLabel = new OpacityLabel();
			godFatherLabel.Size = new System.Drawing.Size(200, 30);
			godFatherLabel.Location = new System.Drawing.Point(0, 320);
			godFatherLabel.Text = "Крёстный в МИЦ";
			godFatherLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Controls.Add(godFatherLabel);
		}

		private void godFather_Click(object sender, EventArgs e) {
			Program.Data.PutInGodFather(member);
		}

		private void enterDate_Click(object sender, EventArgs e) {
			Program.Data.PutInSameEnterDateMembers(DateTime.Parse(enterDate.Text));
		}

		private void city_Click(object sender, EventArgs e) {
			Program.Data.PutInSameCityMembers(city.Text);
		}

		private void birthDay_Click(object sender, EventArgs e) {
			Program.Data.PutInSameBDayMembers(DateTime.Parse(birthDay.Text));
		}
	}
}