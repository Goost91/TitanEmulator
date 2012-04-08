namespace TitanEmulator {
    public class Register {
        public byte value;
        public int index;

        public Register(int v, int i) {
            value = (byte) v;
            index = i;
        }
    }
}
