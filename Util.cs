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
            //mc.ConnectionString = "server = localhost; user = root; database = yf15; port = 3306; password = mysql";

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
                "TargetBackPressure,HydrostaticPressure,State_1,State_2 from oil_3 where id = " + id;
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
                /*obj.setState_1((Double)rdr[68]);
                obj.setState_2((Double)rdr[69]);*/
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
    }
}
