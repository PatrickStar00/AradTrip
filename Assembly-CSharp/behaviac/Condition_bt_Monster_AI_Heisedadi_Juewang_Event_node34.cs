﻿using System;

namespace behaviac
{
	// Token: 0x02003496 RID: 13462
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Heisedadi_Juewang_Event_node34 : Condition
	{
		// Token: 0x06015175 RID: 86389 RVA: 0x0065A81E File Offset: 0x00658C1E
		public Condition_bt_Monster_AI_Heisedadi_Juewang_Event_node34()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 560001;
		}

		// Token: 0x06015176 RID: 86390 RVA: 0x0065A840 File Offset: 0x00658C40
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EA6F RID: 60015
		private BE_Target opl_p0;

		// Token: 0x0400EA70 RID: 60016
		private BE_Equal opl_p1;

		// Token: 0x0400EA71 RID: 60017
		private int opl_p2;
	}
}
