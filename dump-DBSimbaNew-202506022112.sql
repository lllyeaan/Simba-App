--
-- PostgreSQL database dump
--

-- Dumped from database version 17.4
-- Dumped by pg_dump version 17.4

-- Started on 2025-06-02 21:12:42

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4 (class 2615 OID 2200)
-- Name: public; Type: SCHEMA; Schema: -; Owner: pg_database_owner
--

CREATE SCHEMA public;


ALTER SCHEMA public OWNER TO pg_database_owner;

--
-- TOC entry 5028 (class 0 OID 0)
-- Dependencies: 4
-- Name: SCHEMA public; Type: COMMENT; Schema: -; Owner: pg_database_owner
--

COMMENT ON SCHEMA public IS 'standard public schema';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 236 (class 1259 OID 17158)
-- Name: contact_info; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.contact_info (
    id_contact integer NOT NULL,
    contact_type character varying(20) NOT NULL,
    contact_value character varying(50) NOT NULL,
    description character varying(100),
    CONSTRAINT contact_info_contact_type_check CHECK (((contact_type)::text = ANY ((ARRAY['Phone'::character varying, 'Email'::character varying, 'WhatsApp'::character varying])::text[])))
);


ALTER TABLE public.contact_info OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 17001)
-- Name: customer_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.customer_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.customer_id_seq OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 17054)
-- Name: customer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.customer (
    id_customer integer DEFAULT nextval('public.customer_id_seq'::regclass) NOT NULL,
    id_user integer NOT NULL,
    nama_customer character varying(100) NOT NULL,
    no_hp character varying(15),
    alamat_jalan character varying(100),
    id_desa integer,
    id_kecamatan character(6),
    id_kabupaten character(4),
    id_provinsi character(2),
    alamat_deskripsi text
);


ALTER TABLE public.customer OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 17007)
-- Name: desa_kelurahan_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.desa_kelurahan_id_seq
    START WITH 153
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.desa_kelurahan_id_seq OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 17033)
-- Name: desa_kelurahan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.desa_kelurahan (
    id_desa integer DEFAULT nextval('public.desa_kelurahan_id_seq'::regclass) NOT NULL,
    id_kecamatan character(6) NOT NULL,
    nama_desa_kelurahan character varying(100) NOT NULL
);


ALTER TABLE public.desa_kelurahan OWNER TO postgres;

--
-- TOC entry 235 (class 1259 OID 17143)
-- Name: detail_orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.detail_orders (
    id_order integer NOT NULL,
    id_material integer NOT NULL,
    quantity integer NOT NULL,
    subtotal integer NOT NULL
);


ALTER TABLE public.detail_orders OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 17004)
-- Name: driver_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.driver_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.driver_id_seq OWNER TO postgres;

--
-- TOC entry 231 (class 1259 OID 17092)
-- Name: driver; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.driver (
    id_driver integer DEFAULT nextval('public.driver_id_seq'::regclass) NOT NULL,
    nama character varying(100) NOT NULL,
    no_hp character varying(15)
);


ALTER TABLE public.driver OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 17013)
-- Name: kabupaten; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kabupaten (
    id_kabupaten character(4) NOT NULL,
    id_provinsi character(2) NOT NULL,
    nama_kabupaten character varying(100)
);


ALTER TABLE public.kabupaten OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 17023)
-- Name: kecamatan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kecamatan (
    id_kecamatan character(6) NOT NULL,
    id_kabupaten character(4) NOT NULL,
    nama_kecamatan character varying(60) NOT NULL,
    kode_pos character varying(5),
    jumlah_desa integer,
    jumlah_kelurahan integer,
    status character varying(20)
);


ALTER TABLE public.kecamatan OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 17002)
-- Name: material_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.material_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.material_id_seq OWNER TO postgres;

--
-- TOC entry 233 (class 1259 OID 17116)
-- Name: materials; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.materials (
    id_material integer DEFAULT nextval('public.material_id_seq'::regclass) NOT NULL,
    material_name character varying(100) NOT NULL,
    unit_price integer NOT NULL,
    stock integer,
    satuan character varying(30) NOT NULL,
    is_available boolean DEFAULT true
);


ALTER TABLE public.materials OWNER TO postgres;

--
-- TOC entry 230 (class 1259 OID 17087)
-- Name: merek; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.merek (
    id_merek character(6) NOT NULL,
    nama_merek character varying(20) NOT NULL
);


ALTER TABLE public.merek OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 17006)
-- Name: order_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.order_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.order_id_seq OWNER TO postgres;

--
-- TOC entry 234 (class 1259 OID 17123)
-- Name: orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.orders (
    id_order integer DEFAULT nextval('public.order_id_seq'::regclass) NOT NULL,
    id_customer integer NOT NULL,
    id_truck integer,
    order_date date DEFAULT CURRENT_DATE NOT NULL,
    shipped_date date,
    payment_method character varying(10) NOT NULL,
    payment_status character varying(20) NOT NULL,
    delivery_status character varying(20) NOT NULL,
    proof_of_transfer character varying(255),
    CONSTRAINT orders_delivery_status_check CHECK (((delivery_status)::text = ANY ((ARRAY['Pending'::character varying, 'Confirmed'::character varying, 'Shipped'::character varying, 'Delivered'::character varying])::text[]))),
    CONSTRAINT orders_payment_method_check CHECK (((payment_method)::text = ANY ((ARRAY['COD'::character varying, 'Transfer'::character varying])::text[]))),
    CONSTRAINT orders_payment_status_check CHECK (((payment_status)::text = ANY ((ARRAY['Pending'::character varying, 'Confirmed'::character varying, 'Failed'::character varying])::text[])))
);


ALTER TABLE public.orders OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 17008)
-- Name: provinsi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.provinsi (
    id_provinsi character(2) NOT NULL,
    nama_provinsi character varying(60) NOT NULL
);


ALTER TABLE public.provinsi OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 17005)
-- Name: truck_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.truck_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.truck_id_seq OWNER TO postgres;

--
-- TOC entry 232 (class 1259 OID 17098)
-- Name: truck; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.truck (
    id_truck integer DEFAULT nextval('public.truck_id_seq'::regclass) NOT NULL,
    no_polisi character varying(10) NOT NULL,
    id_merek character(6),
    tipe character varying(30),
    kapasitas integer NOT NULL,
    id_driver integer
);


ALTER TABLE public.truck OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 17003)
-- Name: user_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.user_id_seq OWNER TO postgres;

--
-- TOC entry 228 (class 1259 OID 17044)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id_user integer DEFAULT nextval('public.user_id_seq'::regclass) NOT NULL,
    username character varying(20) NOT NULL,
    password character varying(255) NOT NULL,
    role character varying(15) NOT NULL,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT users_role_check CHECK (((role)::text = ANY ((ARRAY['admin'::character varying, 'customer'::character varying])::text[])))
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 5022 (class 0 OID 17158)
-- Dependencies: 236
-- Data for Name: contact_info; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.contact_info (id_contact, contact_type, contact_value, description) FROM stdin;
1	WhatsApp	082132492054	Customer Service
\.


--
-- TOC entry 5015 (class 0 OID 17054)
-- Dependencies: 229
-- Data for Name: customer; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.customer (id_customer, id_user, nama_customer, no_hp, alamat_jalan, id_desa, id_kecamatan, id_kabupaten, id_provinsi, alamat_deskripsi) FROM stdin;
\.


--
-- TOC entry 5013 (class 0 OID 17033)
-- Dependencies: 227
-- Data for Name: desa_kelurahan; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.desa_kelurahan (id_desa, id_kecamatan, nama_desa_kelurahan) FROM stdin;
77	350101	Kandangan
78	350101	Pesanggaran
79	350101	Sarongan
80	350101	Sumberagung
81	350101	Sumbermulyo
82	350102	Bangorejo
83	350102	Kebondalem
84	350102	Ringintelu
85	350102	Sambimulyo
86	350102	Sambirejo
87	350102	Sukorejo
88	350102	Temurejo
89	350103	Bulurejo
90	350103	Glagahagung
91	350103	Grajagan
92	350103	Karetan
93	350103	Kradenan
94	350103	Purwoharjo
95	350103	Sidorejo
96	350103	Sumberasri
97	350104	Kalipait
98	350104	Kedungasri
99	350104	Kedunggebang
100	350104	Kedungwungu
101	350104	Kendalrejo
102	350104	Purwoagung
103	350104	Purwoasri
104	350104	Tegaldlimo
105	350104	Wringinpitu
106	350105	Blambangan
107	350105	Kedungrejo
108	350105	Kedungringin
109	350105	Kumendung
110	350105	Sumber Beras
111	350105	Sumbersewu
112	350105	Tambakrejo
113	350105	Tapanrejo
114	350105	Tembokrejo
115	350105	Wringinputih
116	350106	Benculuk
117	350106	Cluring
118	350106	Kaliploso
119	350106	Plampangrejo
120	350106	Sarimulyo
121	350106	Sembulung
122	350106	Sraten
123	350106	Tamanagung
124	350106	Tampo
125	350107	Purwodadi
126	350107	Jajag
127	350107	Gambiran
128	350107	Yosomulyo
129	350107	Wringinrejo
130	350107	Wringinagung
131	350108	Bagorejo
132	350108	Wonosobo
133	350108	Sukonatar
134	350108	Kebaman
135	350108	Sumbersari
136	350108	Parijatah Wetan
137	350108	Parijatah Kulon
138	350108	Rejoagung
139	350108	Kepundungan
140	350108	Sukomaju
141	350109	Kembiritan
142	350109	Gentengwetan
143	350109	Gentengkulon
144	350109	Setail
145	350109	Kaligondo
146	350110	Tegalharjo
147	350110	Sepanjang
148	350110	Karangharjo
149	350110	Tulungrejo
150	350110	Sumbergondo
151	350110	Bumiharjo
152	350110	Margomulyo
\.


--
-- TOC entry 5021 (class 0 OID 17143)
-- Dependencies: 235
-- Data for Name: detail_orders; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.detail_orders (id_order, id_material, quantity, subtotal) FROM stdin;
\.


--
-- TOC entry 5017 (class 0 OID 17092)
-- Dependencies: 231
-- Data for Name: driver; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.driver (id_driver, nama, no_hp) FROM stdin;
\.


--
-- TOC entry 5011 (class 0 OID 17013)
-- Dependencies: 225
-- Data for Name: kabupaten; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kabupaten (id_kabupaten, id_provinsi, nama_kabupaten) FROM stdin;
3501	35	Banyuwangi
\.


--
-- TOC entry 5012 (class 0 OID 17023)
-- Dependencies: 226
-- Data for Name: kecamatan; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kecamatan (id_kecamatan, id_kabupaten, nama_kecamatan, kode_pos, jumlah_desa, jumlah_kelurahan, status) FROM stdin;
350101	3501	Pesanggaran	68489	5	0	Desa
350102	3501	Bangorejo	68487	7	0	Desa
350103	3501	Purwoharjo	68483	8	0	Desa
350104	3501	Tegaldlimo	68484	9	0	Desa
350105	3501	Muncar	68472	10	0	Desa
350106	3501	Cluring	68482	9	0	Desa
350107	3501	Gambiran	68486	6	0	Desa
350108	3501	Srono	68471	10	0	Desa
350109	3501	Genteng	68465	5	0	Desa
350110	3501	Glenmore	68466	7	0	Desa
\.


--
-- TOC entry 5019 (class 0 OID 17116)
-- Dependencies: 233
-- Data for Name: materials; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.materials (id_material, material_name, unit_price, stock, satuan, is_available) FROM stdin;
1	Batu Pecah	630000	100	Kubik	t
2	Sirtu (Pasir Berbatu)	300000	200	Kubik	t
3	Tanah	270000	150	Kubik	t
4	Raeng	1500	50	Biji	t
5	Pasir Biasa	550000	300	Kubik	t
6	Pasir Kering	650000	250	Kubik	t
7	Pasir Halus	750000	200	Kubik	t
8	Batu Coral	320000	150	Kubik	t
9	Batu	6000000	100	Kubik	t
\.


--
-- TOC entry 5016 (class 0 OID 17087)
-- Dependencies: 230
-- Data for Name: merek; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.merek (id_merek, nama_merek) FROM stdin;
\.


--
-- TOC entry 5020 (class 0 OID 17123)
-- Dependencies: 234
-- Data for Name: orders; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.orders (id_order, id_customer, id_truck, order_date, shipped_date, payment_method, payment_status, delivery_status, proof_of_transfer) FROM stdin;
\.


--
-- TOC entry 5010 (class 0 OID 17008)
-- Dependencies: 224
-- Data for Name: provinsi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.provinsi (id_provinsi, nama_provinsi) FROM stdin;
35	Jawa Timur
\.


--
-- TOC entry 5018 (class 0 OID 17098)
-- Dependencies: 232
-- Data for Name: truck; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.truck (id_truck, no_polisi, id_merek, tipe, kapasitas, id_driver) FROM stdin;
\.


--
-- TOC entry 5014 (class 0 OID 17044)
-- Dependencies: 228
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id_user, username, password, role, created_at) FROM stdin;
1	admin123		admin	2025-06-01 16:38:17.141306
2	AdminSimba	admin123	admin	2025-06-01 22:13:33.726041
3	KhalyanaK	Khal123	customer	2025-06-01 23:30:48.293076
\.


--
-- TOC entry 5029 (class 0 OID 0)
-- Dependencies: 217
-- Name: customer_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.customer_id_seq', 1, false);


--
-- TOC entry 5030 (class 0 OID 0)
-- Dependencies: 223
-- Name: desa_kelurahan_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.desa_kelurahan_id_seq', 153, false);


--
-- TOC entry 5031 (class 0 OID 0)
-- Dependencies: 220
-- Name: driver_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.driver_id_seq', 1, false);


--
-- TOC entry 5032 (class 0 OID 0)
-- Dependencies: 218
-- Name: material_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.material_id_seq', 9, true);


--
-- TOC entry 5033 (class 0 OID 0)
-- Dependencies: 222
-- Name: order_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.order_id_seq', 1, false);


--
-- TOC entry 5034 (class 0 OID 0)
-- Dependencies: 221
-- Name: truck_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.truck_id_seq', 1, false);


--
-- TOC entry 5035 (class 0 OID 0)
-- Dependencies: 219
-- Name: user_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.user_id_seq', 3, true);


--
-- TOC entry 4843 (class 2606 OID 17163)
-- Name: contact_info contact_info_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.contact_info
    ADD CONSTRAINT contact_info_pkey PRIMARY KEY (id_contact);


--
-- TOC entry 4824 (class 2606 OID 17061)
-- Name: customer customer_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (id_customer);


--
-- TOC entry 4818 (class 2606 OID 17038)
-- Name: desa_kelurahan desa_kelurahan_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.desa_kelurahan
    ADD CONSTRAINT desa_kelurahan_pkey PRIMARY KEY (id_desa);


--
-- TOC entry 4841 (class 2606 OID 17147)
-- Name: detail_orders detail_orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detail_orders
    ADD CONSTRAINT detail_orders_pkey PRIMARY KEY (id_order, id_material);


--
-- TOC entry 4829 (class 2606 OID 17097)
-- Name: driver driver_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.driver
    ADD CONSTRAINT driver_pkey PRIMARY KEY (id_driver);


--
-- TOC entry 4814 (class 2606 OID 17017)
-- Name: kabupaten kabupaten_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kabupaten
    ADD CONSTRAINT kabupaten_pkey PRIMARY KEY (id_kabupaten);


--
-- TOC entry 4816 (class 2606 OID 17027)
-- Name: kecamatan kecamatan_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kecamatan
    ADD CONSTRAINT kecamatan_pkey PRIMARY KEY (id_kecamatan);


--
-- TOC entry 4835 (class 2606 OID 17122)
-- Name: materials materials_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.materials
    ADD CONSTRAINT materials_pkey PRIMARY KEY (id_material);


--
-- TOC entry 4827 (class 2606 OID 17091)
-- Name: merek merek_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.merek
    ADD CONSTRAINT merek_pkey PRIMARY KEY (id_merek);


--
-- TOC entry 4839 (class 2606 OID 17132)
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (id_order);


--
-- TOC entry 4812 (class 2606 OID 17012)
-- Name: provinsi provinsi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.provinsi
    ADD CONSTRAINT provinsi_pkey PRIMARY KEY (id_provinsi);


--
-- TOC entry 4831 (class 2606 OID 17105)
-- Name: truck truck_no_polisi_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.truck
    ADD CONSTRAINT truck_no_polisi_key UNIQUE (no_polisi);


--
-- TOC entry 4833 (class 2606 OID 17103)
-- Name: truck truck_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.truck
    ADD CONSTRAINT truck_pkey PRIMARY KEY (id_truck);


--
-- TOC entry 4820 (class 2606 OID 17051)
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id_user);


--
-- TOC entry 4822 (class 2606 OID 17053)
-- Name: users users_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_username_key UNIQUE (username);


--
-- TOC entry 4825 (class 1259 OID 17166)
-- Name: idx_customer_user; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_customer_user ON public.customer USING btree (id_user);


--
-- TOC entry 4836 (class 1259 OID 17164)
-- Name: idx_orders_customer; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_orders_customer ON public.orders USING btree (id_customer);


--
-- TOC entry 4837 (class 1259 OID 17165)
-- Name: idx_orders_date; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_orders_date ON public.orders USING btree (order_date);


--
-- TOC entry 4847 (class 2606 OID 17067)
-- Name: customer customer_id_desa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_desa_fkey FOREIGN KEY (id_desa) REFERENCES public.desa_kelurahan(id_desa);


--
-- TOC entry 4848 (class 2606 OID 17077)
-- Name: customer customer_id_kabupaten_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_kabupaten_fkey FOREIGN KEY (id_kabupaten) REFERENCES public.kabupaten(id_kabupaten);


--
-- TOC entry 4849 (class 2606 OID 17072)
-- Name: customer customer_id_kecamatan_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_kecamatan_fkey FOREIGN KEY (id_kecamatan) REFERENCES public.kecamatan(id_kecamatan);


--
-- TOC entry 4850 (class 2606 OID 17082)
-- Name: customer customer_id_provinsi_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_provinsi_fkey FOREIGN KEY (id_provinsi) REFERENCES public.provinsi(id_provinsi);


--
-- TOC entry 4851 (class 2606 OID 17062)
-- Name: customer customer_id_user_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_user_fkey FOREIGN KEY (id_user) REFERENCES public.users(id_user);


--
-- TOC entry 4846 (class 2606 OID 17039)
-- Name: desa_kelurahan desa_kelurahan_id_kecamatan_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.desa_kelurahan
    ADD CONSTRAINT desa_kelurahan_id_kecamatan_fkey FOREIGN KEY (id_kecamatan) REFERENCES public.kecamatan(id_kecamatan);


--
-- TOC entry 4856 (class 2606 OID 17153)
-- Name: detail_orders detail_orders_id_material_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detail_orders
    ADD CONSTRAINT detail_orders_id_material_fkey FOREIGN KEY (id_material) REFERENCES public.materials(id_material);


--
-- TOC entry 4857 (class 2606 OID 17148)
-- Name: detail_orders detail_orders_id_order_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detail_orders
    ADD CONSTRAINT detail_orders_id_order_fkey FOREIGN KEY (id_order) REFERENCES public.orders(id_order);


--
-- TOC entry 4844 (class 2606 OID 17018)
-- Name: kabupaten kabupaten_id_provinsi_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kabupaten
    ADD CONSTRAINT kabupaten_id_provinsi_fkey FOREIGN KEY (id_provinsi) REFERENCES public.provinsi(id_provinsi);


--
-- TOC entry 4845 (class 2606 OID 17028)
-- Name: kecamatan kecamatan_id_kabupaten_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kecamatan
    ADD CONSTRAINT kecamatan_id_kabupaten_fkey FOREIGN KEY (id_kabupaten) REFERENCES public.kabupaten(id_kabupaten);


--
-- TOC entry 4854 (class 2606 OID 17133)
-- Name: orders orders_id_customer_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_id_customer_fkey FOREIGN KEY (id_customer) REFERENCES public.customer(id_customer);


--
-- TOC entry 4855 (class 2606 OID 17138)
-- Name: orders orders_id_truck_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_id_truck_fkey FOREIGN KEY (id_truck) REFERENCES public.truck(id_truck);


--
-- TOC entry 4852 (class 2606 OID 17111)
-- Name: truck truck_id_driver_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.truck
    ADD CONSTRAINT truck_id_driver_fkey FOREIGN KEY (id_driver) REFERENCES public.driver(id_driver);


--
-- TOC entry 4853 (class 2606 OID 17106)
-- Name: truck truck_id_merek_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.truck
    ADD CONSTRAINT truck_id_merek_fkey FOREIGN KEY (id_merek) REFERENCES public.merek(id_merek);


-- Completed on 2025-06-02 21:12:42

--
-- PostgreSQL database dump complete
--

