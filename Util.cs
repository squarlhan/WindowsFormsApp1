using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBTestCs
{
    class Util
    {
        MySqlConnection mc;

        public void init() {
            //实例化连接对象
            mc = new MySqlConnection();
            mc.ConnectionString = "server = 47.95.144.194; user = root; database = yf15; port = 3306; password = ";
            //mc.ConnectionString = "server = localhost; user = root; database = yf15; port = 3306; password = 123456";
            mc.Open();
        }

        public Oil GetOilFromDB(int id) {
            string sql = "SELECT id,DateTime,Time,WellDep,HangDownDeep,DepthOfTheDrillBit," +
                "DrillDownDeep,DrillingTime,BitPressure,HangingLoad,RotationRate,Torque,KellyDown," +
                "HookPosition,HookSpeed,StandpipePressurelog,CasingPressure,PumpStroke1,PumpStroke2," +
                "PumpStroke3,TotalPoolSize,LayTime,MudSpill,InletFlowlog,OutletFlowlog,InletDensitylog," +
                "OutletDensitylog,EntranceTempreture,ExitTempreture,TotalHydrocarbon,H2S,C1,C2,PWDDepth," +
                "PWDHangDownDeep,PWD_zzyl,PWD_hkyl,PWD_hkwd,PWD_cl_ECD,PWDWellDeviation,PWDLocation,qztj," +
                "UpturnDepth,OperatorSchema,StandpipePressure,MeasurementOfBackPressure,OutletFlow,OutletDensity," +
                "BackPressurePumpFlow,LoopBackPressure,AdditionalBackPressure,InletFlow,FixDepth,FixPointDownDeep," +
                "FixPointPressure,WellMouthAdjustment,FixPointPressureLoss,BoDongYL,YaHaoXZ,QiXiaZuanSD," +
                "QiXiaZuanJSD,FixPointECD,DrillECD,DrillStringPressureDrop,DrillBitPressureDrop,EnvironmentalControlPressureLoss," +
                "TargetBackPressure,HydrostaticPressure,State_1,State_2 from oil_2 where id = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, mc);

            MySqlDataReader rdr = cmd.ExecuteReader();
            Oil obj = new Oil();
            while (rdr.Read())
            {
                obj.setDateTime((String)rdr[1]);
                obj.setTime((Double)rdr[2]);
                obj.setWellDep((Double)rdr[3]);
                obj.setHangDownDeep((Double)rdr[4]);
                obj.setDepthOfTheDrillBit((Double)rdr[5]);
                obj.setDrillDownDeep((Double)rdr[6]);
                obj.setDrillingTime((Double)rdr[7]);
                obj.setBitPressure((Double)rdr[8]);
                obj.setHangingLoad((Double)rdr[9]);
                obj.setRotationRate((Double)rdr[10]);
                obj.setTorque((Double)rdr[11]);
                obj.setKellyDown((Double)rdr[12]);
                obj.setHookPosition((Double)rdr[13]);
                obj.setHookSpeed((Double)rdr[14]);
                obj.setStandpipePressurelog((Double)rdr[15]);
                obj.setCasingPressure((Double)rdr[16]);
                obj.setPumpStroke1((Double)rdr[17]);
                obj.setPumpStroke2((Double)rdr[18]);
                obj.setPumpStroke3((Double)rdr[19]);
                obj.setTotalPoolSize((Double)rdr[20]);
                obj.setLayTime((Double)rdr[21]);
                obj.setMudSpill((Double)rdr[22]);
                obj.setInletFlowlog((Double)rdr[23]);
                obj.setOutletFlowlog((Double)rdr[24]);
                obj.setInletDensitylog((Double)rdr[25]);
                obj.setOutletDensitylog((Double)rdr[26]);
                obj.setEntranceTempreture((Double)rdr[27]);
                obj.setExitTempreture((Double)rdr[28]);
                obj.setTotalHydrocarbon((Double)rdr[29]);
                obj.setH2S((Double)rdr[30]);
                obj.setC1((Double)rdr[31]);
                obj.setC2((Double)rdr[32]);
                obj.setPWDDepth((Double)rdr[33]);
                obj.setPWDHangDownDeep((Double)rdr[34]);
                obj.setPWD_zzyl((Double)rdr[35]);
                obj.setPWD_hkyl((Double)rdr[36]);
                obj.setPWD_hkwd((Double)rdr[37]);
                obj.setPWD_cl_ECD((Double)rdr[38]);
                obj.setPWDWellDeviation((Double)rdr[39]);
                obj.setPWDLocation((Double)rdr[40]);
                obj.setQztj((Double)rdr[41]);
                obj.setUpturnDepth((Double)rdr[42]);
                obj.setOperatorSchema((Double)rdr[43]);
                obj.setStandpipePressure((Double)rdr[44]);
                obj.setMeasurementOfBackPressure((Double)rdr[45]);
                obj.setOutletFlow((Double)rdr[46]);
                obj.setOutletDensity((Double)rdr[47]);
                obj.setBackPressurePumpFlow((Double)rdr[48]);
                obj.setLoopBackPressure((Double)rdr[49]);
                obj.setAdditionalBackPressure((Double)rdr[50]);
                obj.setInletFlow((Double)rdr[51]);
                obj.setFixDepth((Double)rdr[52]);
                obj.setFixPointDownDeep((Double)rdr[53]);
                obj.setFixPointPressure((Double)rdr[54]);
                obj.setWellMouthAdjustment((Double)rdr[55]);
                obj.setFixPointPressureLoss((Double)rdr[56]);
                obj.setBoDongYL((Double)rdr[57]);
                obj.setYaHaoXZ((Double)rdr[58]);
                obj.setQiXiaZuanSD((Double)rdr[59]);
                obj.setQiXiaZuanJSD((Double)rdr[60]);
                obj.setFixPointECD((Double)rdr[61]);
                obj.setDrillECD((Double)rdr[62]);
                obj.setDrillStringPressureDrop((Double)rdr[63]);
                obj.setDrillBitPressureDrop((Double)rdr[64]);
                obj.setEnvironmentalControlPressureLoss((Double)rdr[65]);
                obj.setTargetBackPressure((Double)rdr[66]);
                obj.setHydrostaticPressure((Double)rdr[67]);
                obj.setState_1((Double)rdr[68]);
                obj.setState_2((Double)rdr[69]);
            }
            rdr.Close();
            return obj;
        }

        public void SetOilToDB(Oil obj) {
            string sql = "insert into oil_2 " +
                "(DateTime,Time,WellDep,HangDownDeep,DepthOfTheDrillBit," +
                "DrillDownDeep,DrillingTime,BitPressure,HangingLoad,RotationRate,Torque,KellyDown," +
                "HookPosition,HookSpeed,StandpipePressurelog,CasingPressure,PumpStroke1,PumpStroke2," +
                "PumpStroke3,TotalPoolSize,LayTime,MudSpill,InletFlowlog,OutletFlowlog,InletDensitylog," +
                "OutletDensitylog,EntranceTempreture,ExitTempreture,TotalHydrocarbon,H2S,C1,C2,PWDDepth," +
                "PWDHangDownDeep,PWD_zzyl,PWD_hkyl,PWD_hkwd,PWD_cl_ECD,PWDWellDeviation,PWDLocation,qztj," +
                "UpturnDepth,OperatorSchema,StandpipePressure,MeasurementOfBackPressure,OutletFlow,OutletDensity," +
                "BackPressurePumpFlow,LoopBackPressure,AdditionalBackPressure,InletFlow,FixDepth,FixPointDownDeep," +
                "FixPointPressure,WellMouthAdjustment,FixPointPressureLoss,BoDongYL,YaHaoXZ,QiXiaZuanSD," +
                "QiXiaZuanJSD,FixPointECD,DrillECD,DrillStringPressureDrop,DrillBitPressureDrop,EnvironmentalControlPressureLoss," +
                "TargetBackPressure,HydrostaticPressure,State_1,State_2) " +
                " values( '" + obj.getDateTime() + "'," +obj.getTime() + "," +obj.getWellDep() + "," +obj.getHangDownDeep() + "," +obj.getDepthOfTheDrillBit() + "," +
                obj.getDrillDownDeep() + "," +obj.getDrillingTime() + "," +obj.getBitPressure() + "," +obj.getHangingLoad() + "," +obj.getRotationRate() + "," +
                obj.getTorque() + "," +obj.getKellyDown() + "," +obj.getHookPosition() + "," +obj.getHookSpeed() + "," +obj.getStandpipePressurelog() + "," +
                obj.getCasingPressure() + "," +obj.getPumpStroke1() + "," +obj.getPumpStroke2() + "," +obj.getPumpStroke3() + "," +obj.getTotalPoolSize() + "," +
                obj.getLayTime() + "," +obj.getMudSpill() + "," +obj.getInletFlowlog() + "," +obj.getOutletFlowlog() + "," +obj.getInletDensitylog() + "," +
                obj.getOutletDensitylog() + "," +obj.getEntranceTempreture() + "," +obj.getExitTempreture() + "," +obj.getTotalHydrocarbon() + "," +obj.getH2S() + "," +
                obj.getC1() + "," + obj.getC2() + "," + obj.getPWDDepth() + "," + obj.getPWDHangDownDeep() + "," + obj.getPWD_zzyl() + "," +
                obj.getPWD_hkyl() + "," + obj.getPWD_hkwd() + "," + obj.getPWD_cl_ECD() + "," + obj.getPWDWellDeviation() + "," + obj.getPWDLocation() + "," +
                obj.getQztj() + "," + obj.getUpturnDepth() + "," + obj.getOperatorSchema() + "," + obj.getStandpipePressure() + "," + obj.getMeasurementOfBackPressure() + "," +
                obj.getOutletFlow() + "," + obj.getOutletDensity() + "," + obj.getBackPressurePumpFlow() + "," + obj.getLoopBackPressure() + "," + obj.getAdditionalBackPressure() + "," +
                obj.getInletFlow() + "," + obj.getFixDepth() + "," + obj.getFixPointDownDeep() + "," + obj.getFixPointPressure() + "," + obj.getWellMouthAdjustment() + "," +
                obj.getFixPointPressureLoss() + "," + obj.getBoDongYL() + "," + obj.getYaHaoXZ() + "," + obj.getQiXiaZuanSD() + "," + obj.getQiXiaZuanJSD() + "," +
                obj.getFixPointECD() + "," + obj.getDrillECD() + "," + obj.getDrillStringPressureDrop() + "," + obj.getDrillBitPressureDrop() + "," + obj.getEnvironmentalControlPressureLoss() + "," +
                obj.getTargetBackPressure() + "," + obj.getHydrostaticPressure() + "," + obj.getState_1() + "," + obj.getState_2() + ")";

            MySqlCommand cmd = new MySqlCommand(sql, mc);

            cmd.ExecuteNonQuery();
        }


        public static string[] value_name = {
            "", "ZuanTSD", "JingS", "ChiDSJ", "RuKLL", "RuKMD", "NiJBXQ", "BengC", "AnQYLYL", "JieLHYL", "HuiYSZ", "HuanKMZ",
            "JieLF_A", "JieLF_B", "JieLF_C", "GongKBD", "1#GTZJ", "1#GTSL", "1#CC", "2#GTZJ", "2#GTSL", "2#CC", "3#GTZJ", 
            "3#GTSL", "3#CC", "NiJBGL", "TingZJYPD", "QiDSYPD", "LiuLPD", "TG1_NJ", "TG1_XS", "TG2_NJ", "TG2_XS", "TG3_NJ",
            "TG3_XS", "LYD_NJ", "LYD_XS", "HuanKRJ", "ZG1_WJ", "ZG1_DGCD", "ZG1_JTWJ", "ZG1_JTCD", "ZG1_ZDC", "ZG2_WJ",
            "ZG2_DGCD", "ZG2_JTWJ", "ZG2_JTCD", "ZG2_ZDC", "ZT1_WJ", "ZT1_DGCD", "ZT1_JTWJ", "ZT1_JTCD", "ZT1_ZDC", "ZT2_WJ",
            "ZT2_DGCD", "ZT2_JTWJ", "ZT2_JTCD", "ZT2_ZDC", "ZT3_WJ", "ZT3_DGCD", "ZT3_JTWJ", "ZT3_JTCD", "ZT3_ZDC", "LL_Time", 
            "LL_MAX", "YL_Time", "YL_MAX", "YZ_RKLLC", "YZ_JKYL", "YZ_LGYL", "YZ_RKLLCJF", "YZ_JKYLBHL", "YZ_CRKLLBHL", 
            "YZ_LGYLBHL", "ZN_CDTime", "ZN_TBTime", "ZN_JKYLBHL", "ZN_NJB"
        };
        public static string[] value_info = {
            "", "钻头深度", "井深", "迟到时间", "入口流量(L/s)", "入口密度(g/cm3)", "泥浆泵选取", "泵冲(rpm)", 
            "安全压力余量(Mpa)", "节流后压力(Mpa）", "回压设置(Mpa)", "环空摩阻（Mpa）", "节流阀A开度", "节流阀B开度", 
            "节流阀C开度", "1人工，0智能 标定工况", "1#缸套直径(mm)", "1#缸套数量", "1#冲程(mm)", "2#缸套直径(mm)", 
            "2#缸套数量", "2#冲程(mm)", "3#套缸直径(mm)", "3#套缸数量", "3#冲程(mm)", "泥浆泵功率", "停止降压判断值", 
            "启动升压判断值", "流量判断值", "套管1_内径", "套管1_下深(m)", "套管2_内径", "套管2_下深(m）", "套管3_内径", 
            "套管3_下深(m)", "裸眼段_内径", "裸眼段_下深(m)", "环空容积", "钻杆1_外径", "钻杆1_单根长度", "钻杆1_接头外径", 
            "钻杆1_接头长度", "钻杆1_总段长", "钻杆2_外径", "钻杆2_单根长度", "钻杆2_接头外径", "钻杆2_接头长度", 
            "钻杆2_总段长", "钻铤1_外径", "钻铤1_单根长度", "钻铤1_接头外径", "钻铤1_接头长度", "钻铤1_总段长", "钻铤2_外径",
            "钻铤2_单根长度", "钻铤2_接头外径", "钻铤2_接头长度", "钻铤2_总段长", "钻铤3_外径", "钻铤3_单根长度", 
            "钻铤3_接头外径", "钻铤3_接头长度", "钻铤3_总段长", "流量_时间显示范围(min）", "流量最大值(L/s）", 
            "压力_时间显示范围(min)", "压力最大值(Mpa)", "阈值_出入口流量差", "阈值_井口压力", "阈值_立管压力", 
            "阈值_出入口流量差积分", "阈值_井口压力变化率", "阈值_出入口流量差变化率", "阈值_立管压力变化率", 
            "智能_迟到时间标定", "智能_停泵时间", "智能_井口压力变化率", "智能_泥浆泵特征"
        };

        public void SetValue(int id, double value) {
            string sql = "insert into `value` values( null,'" + value_name[id] + "', " + value + ",null );"; //'" + value_info[id] + "'

            MySqlCommand cmd = new MySqlCommand(sql, mc);

            cmd.ExecuteNonQuery();
        }

        public double GetValue(int id) {
            string sql = "SELECT value_inner FROM value WHERE value_id =(" +
                "SELECT max(value_id) FROM value WHERE value_name = '" + value_name[id] + "')";
            MySqlCommand cmd = new MySqlCommand(sql, mc);

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                return (double)rdr[0];
            }
            rdr.Close();
            return 0;
        }

        public void SetValue(string id, double value)
        {
            string sql = "insert into `value` values( null,'" + id + "', " + value + ", null);";

            MySqlCommand cmd = new MySqlCommand(sql, mc);

            cmd.ExecuteNonQuery();
        }
    }
}
