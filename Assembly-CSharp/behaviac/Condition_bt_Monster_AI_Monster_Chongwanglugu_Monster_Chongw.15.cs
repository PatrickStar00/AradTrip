﻿using System;

namespace behaviac
{
	// Token: 0x02003604 RID: 13828
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Monster_Chongwanglugu_Monster_Chongwanglugu_Action_node4 : Condition
	{
		// Token: 0x0601542E RID: 87086 RVA: 0x0066894B File Offset: 0x00666D4B
		public Condition_bt_Monster_AI_Monster_Chongwanglugu_Monster_Chongwanglugu_Action_node4()
		{
			this.opl_p0 = 5440;
		}

		// Token: 0x0601542F RID: 87087 RVA: 0x00668960 File Offset: 0x00666D60
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EDE7 RID: 60903
		private int opl_p0;
	}
}
