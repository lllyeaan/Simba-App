--
-- PostgreSQL database dump
--

-- Dumped from database version 17.4
-- Dumped by pg_dump version 17.4

-- Started on 2025-06-15 11:54:10

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
-- TOC entry 219 (class 1259 OID 57787)
-- Name: customer_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.customer_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.customer_id_seq OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 220 (class 1259 OID 57788)
-- Name: customer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.customer (
    id_customer integer DEFAULT nextval('public.customer_id_seq'::regclass) NOT NULL,
    id_user integer NOT NULL,
    nama_customer character varying(100) NOT NULL,
    no_hp character varying(15),
    alamat_jalan character varying(100),
    id_desa integer,
    id_kecamatan character varying(100),
    id_kabupaten character(4),
    id_provinsi character(2),
    alamat_deskripsi text
);


ALTER TABLE public.customer OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 57794)
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
-- TOC entry 222 (class 1259 OID 57795)
-- Name: desa_kelurahan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.desa_kelurahan (
    id_desa integer DEFAULT nextval('public.desa_kelurahan_id_seq'::regclass) NOT NULL,
    id_kecamatan character(6) NOT NULL,
    nama_desa_kelurahan character varying(100) NOT NULL
);


ALTER TABLE public.desa_kelurahan OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 57802)
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
-- TOC entry 224 (class 1259 OID 57807)
-- Name: kabupaten; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kabupaten (
    id_kabupaten character varying(4) NOT NULL,
    id_provinsi character varying(2) NOT NULL,
    nama_kabupaten character varying(100)
);


ALTER TABLE public.kabupaten OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 57810)
-- Name: kecamatan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kecamatan (
    id_kecamatan character varying(6) NOT NULL,
    id_kabupaten character varying(4) NOT NULL,
    nama_kecamatan character varying(60) NOT NULL,
    kode_pos character varying(5),
    jumlah_desa integer,
    jumlah_kelurahan integer,
    status character varying(20)
);


ALTER TABLE public.kecamatan OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 57813)
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
-- TOC entry 227 (class 1259 OID 57814)
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
-- TOC entry 236 (class 1259 OID 65824)
-- Name: merek_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.merek_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.merek_id_seq OWNER TO postgres;

--
-- TOC entry 228 (class 1259 OID 57819)
-- Name: merek; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.merek (
    id_merek character(6) DEFAULT nextval('public.merek_id_seq'::regclass) NOT NULL,
    nama_merek character varying(20) NOT NULL
);


ALTER TABLE public.merek OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 57822)
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
-- TOC entry 230 (class 1259 OID 57823)
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
    delivery_status character varying(20) DEFAULT 'Pending'::character varying,
    proof_of_transfer character varying(255),
    id_material integer NOT NULL,
    unit_price numeric(20,0) NOT NULL,
    quantity integer NOT NULL,
    total numeric(20,0) NOT NULL,
    CONSTRAINT orders_delivery_status_check CHECK (((delivery_status)::text = ANY (ARRAY[('Pending'::character varying)::text, ('Confirmed'::character varying)::text, ('Shipped'::character varying)::text, ('Delivered'::character varying)::text]))),
    CONSTRAINT orders_payment_status_check CHECK (((payment_status)::text = ANY (ARRAY[('Pending'::character varying)::text, ('Confirmed'::character varying)::text, ('Failed'::character varying)::text]))),
    CONSTRAINT payment_method_check CHECK (((payment_method)::text = ANY ((ARRAY['COD'::character varying, 'Transfer'::character varying, 'Pending'::character varying])::text[])))
);


ALTER TABLE public.orders OWNER TO postgres;

--
-- TOC entry 231 (class 1259 OID 57832)
-- Name: provinsi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.provinsi (
    id_provinsi character(2) NOT NULL,
    nama_provinsi character varying(60) NOT NULL
);


ALTER TABLE public.provinsi OWNER TO postgres;

--
-- TOC entry 235 (class 1259 OID 65821)
-- Name: truck; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.truck (
    id_truck integer NOT NULL,
    no_polisi character varying(10),
    id_merek character(6),
    tipe character varying(30),
    kapasitas integer,
    nama character varying(100),
    no_hp character varying(15)
);


ALTER TABLE public.truck OWNER TO postgres;

--
-- TOC entry 232 (class 1259 OID 57835)
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
-- TOC entry 233 (class 1259 OID 57840)
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
-- TOC entry 234 (class 1259 OID 57841)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id_user integer DEFAULT nextval('public.user_id_seq'::regclass) NOT NULL,
    username character varying(20) NOT NULL,
    password character varying(255) NOT NULL,
    role character varying(15) NOT NULL,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP NOT NULL,
    id_customer integer,
    temp_id integer,
    CONSTRAINT users_role_check CHECK (((role)::text = ANY (ARRAY[('admin'::character varying)::text, ('customer'::character varying)::text])))
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 4986 (class 0 OID 57788)
-- Dependencies: 220
-- Data for Name: customer; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.customer (id_customer, id_user, nama_customer, no_hp, alamat_jalan, id_desa, id_kecamatan, id_kabupaten, id_provinsi, alamat_deskripsi) FROM stdin;
13	3	Nayla Alya	628819	Riau	\N	350102	3501	35	\N
14	4	MOMO	62453	Riau	\N	350102	3501	35	\N
15	4	well	62568	kita	\N	350102	3501	35	\N
16	5	aku	624589	jerman	\N	350102	3501	35	\N
17	6	plis	62780	allo	\N	350102	3501	35	\N
18	7	Dimas Juli Pratama	623456576849	Jalan raya gambiran	\N	350107	3501	35	\N
19	8	Nayla Alya Namira	628821912	Riau	\N	350106	3501	35	\N
20	8	Nayla Alya Namira	6288219120490	Jalan Riau	\N	350109	3501	35	\N
21	9	Nayla Alya	628819	Riau	\N	350102	3501	35	\N
22	10	Nayla Alya Namira	6288219120490	Riau	\N	350109	3501	35	\N
23	11	Jimin	6255431	Kalimantan	\N	350102	3501	35	\N
24	12	haha	6278	Riau	\N	350102	3501	35	\N
25	16	anna john	624513891	Riau	\N	350109	3501	35	Riau
\.


--
-- TOC entry 4988 (class 0 OID 57795)
-- Dependencies: 222
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
-- TOC entry 4990 (class 0 OID 57807)
-- Dependencies: 224
-- Data for Name: kabupaten; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kabupaten (id_kabupaten, id_provinsi, nama_kabupaten) FROM stdin;
3501	35	Banyuwangi
\.


--
-- TOC entry 4991 (class 0 OID 57810)
-- Dependencies: 225
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
-- TOC entry 4993 (class 0 OID 57814)
-- Dependencies: 227
-- Data for Name: materials; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.materials (id_material, material_name, unit_price, stock, satuan, is_available) FROM stdin;
1	Batu Pecah	630000	100	Kubik	t
2	Sirtu (Pasir Berbatu)	300000	200	Kubik	t
3	Tanah	270000	150	Kubik	t
4	Pasir Biasa	550000	300	Kubik	t
5	Pasir Kering	650000	250	Kubik	t
6	Pasir Halus	750000	200	Kubik	t
7	Batu Coral	320000	150	Kubik	t
8	Batu	6000000	100	Kubik	t
\.


--
-- TOC entry 4994 (class 0 OID 57819)
-- Dependencies: 228
-- Data for Name: merek; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.merek (id_merek, nama_merek) FROM stdin;
1     	Hino
2     	Mitsubishi
3     	Isuzu
4     	Toyota
5     	Mercedes-Benz
6     	Volvo
7     	MAN
8     	UD Trucks
\.


--
-- TOC entry 4996 (class 0 OID 57823)
-- Dependencies: 230
-- Data for Name: orders; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.orders (id_order, id_customer, id_truck, order_date, shipped_date, payment_method, payment_status, delivery_status, proof_of_transfer, id_material, unit_price, quantity, total) FROM stdin;
38	25	\N	2025-06-14	\N	COD	Pending	Pending	\N	6	6	1	750000
\.


--
-- TOC entry 4997 (class 0 OID 57832)
-- Dependencies: 231
-- Data for Name: provinsi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.provinsi (id_provinsi, nama_provinsi) FROM stdin;
35	Jawa Timur
\.


--
-- TOC entry 5001 (class 0 OID 65821)
-- Dependencies: 235
-- Data for Name: truck; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.truck (id_truck, no_polisi, id_merek, tipe, kapasitas, nama, no_hp) FROM stdin;
1	N 1234 AB	1     	Dutro 130HD	1	Budi Santoso	081234567890
2	N 5678 CD	2     	Canter FE 74	1	Rudi Hartono	081234967896
3	N 9101 EF	3     	Elf NMR 71	1	Tono Wijaya	081234760892
4	N 2345 GH	4     	Dyna 130 XT	1	Agus Saputra	081230567193
5	N 6789 IJ	5     	Actros 3340	1	Dedi Prasetyo	085234560894
6	N 1011 KL	6     	FMX 440	1	Anton Nugroho	081238567825
7	N 1213 MN	7     	TGS 33.480	1	Fajar Ramadhan	081230567396
8	N 1415 OP	8     	Quester CWE 280	1	Joko Sungkowo	082204567877
\.


--
-- TOC entry 5000 (class 0 OID 57841)
-- Dependencies: 234
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id_user, username, password, role, created_at, id_customer, temp_id) FROM stdin;
1	admin123		admin	2025-06-01 16:38:17.141306	\N	\N
2	AdminSimba	admin123	admin	2025-06-01 22:13:33.726041	\N	\N
13	anata	nata24	customer	2025-06-14 02:54:36.508403	\N	\N
14	jimin	park	customer	2025-06-14 08:23:20.991592	\N	\N
3	Khal	123	customer	2025-06-09 21:49:50.368905	13	\N
4	momo	twice	customer	2025-06-10 11:40:13.709499	14	\N
5	ii	i	customer	2025-06-10 12:13:50.202029	16	\N
6	ii1	i	customer	2025-06-10 15:11:08.648422	17	\N
7	Dimas	dimas12	customer	2025-06-10 18:57:04.897015	18	\N
8	namira	pbobagus	customer	2025-06-12 18:44:00.666412	19	\N
9	nmr	namira	customer	2025-06-12 18:50:03.564459	21	\N
10	nam	namira	customer	2025-06-12 18:52:45.855189	22	\N
11	nmirran	password	customer	2025-06-14 01:45:15.548613	23	\N
12	mama	mama	customer	2025-06-14 01:55:23.48783	24	\N
15	alya	alya123	customer	2025-06-14 09:21:23.788147	\N	\N
16	anna	0701	customer	2025-06-14 09:43:08.37642	25	\N
\.


--
-- TOC entry 5008 (class 0 OID 0)
-- Dependencies: 219
-- Name: customer_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.customer_id_seq', 25, true);


--
-- TOC entry 5009 (class 0 OID 0)
-- Dependencies: 221
-- Name: desa_kelurahan_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.desa_kelurahan_id_seq', 153, false);


--
-- TOC entry 5010 (class 0 OID 0)
-- Dependencies: 223
-- Name: driver_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.driver_id_seq', 1, false);


--
-- TOC entry 5011 (class 0 OID 0)
-- Dependencies: 226
-- Name: material_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.material_id_seq', 8, true);


--
-- TOC entry 5012 (class 0 OID 0)
-- Dependencies: 236
-- Name: merek_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.merek_id_seq', 1, false);


--
-- TOC entry 5013 (class 0 OID 0)
-- Dependencies: 229
-- Name: order_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.order_id_seq', 38, true);


--
-- TOC entry 5014 (class 0 OID 0)
-- Dependencies: 232
-- Name: truck_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.truck_id_seq', 1, false);


--
-- TOC entry 5015 (class 0 OID 0)
-- Dependencies: 233
-- Name: user_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.user_id_seq', 16, true);


--
-- TOC entry 4802 (class 2606 OID 57848)
-- Name: customer customer_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (id_customer);


--
-- TOC entry 4805 (class 2606 OID 57850)
-- Name: desa_kelurahan desa_kelurahan_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.desa_kelurahan
    ADD CONSTRAINT desa_kelurahan_pkey PRIMARY KEY (id_desa);


--
-- TOC entry 4807 (class 2606 OID 65827)
-- Name: kabupaten kabupaten_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kabupaten
    ADD CONSTRAINT kabupaten_pkey PRIMARY KEY (id_kabupaten);


--
-- TOC entry 4809 (class 2606 OID 57956)
-- Name: kecamatan kecamatan_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kecamatan
    ADD CONSTRAINT kecamatan_pkey PRIMARY KEY (id_kecamatan);


--
-- TOC entry 4811 (class 2606 OID 57860)
-- Name: materials materials_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.materials
    ADD CONSTRAINT materials_pkey PRIMARY KEY (id_material);


--
-- TOC entry 4813 (class 2606 OID 57862)
-- Name: merek merek_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.merek
    ADD CONSTRAINT merek_pkey PRIMARY KEY (id_merek);


--
-- TOC entry 4817 (class 2606 OID 57864)
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (id_order);


--
-- TOC entry 4819 (class 2606 OID 57866)
-- Name: provinsi provinsi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.provinsi
    ADD CONSTRAINT provinsi_pkey PRIMARY KEY (id_provinsi);


--
-- TOC entry 4827 (class 2606 OID 65883)
-- Name: truck truck_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.truck
    ADD CONSTRAINT truck_pkey PRIMARY KEY (id_truck);


--
-- TOC entry 4821 (class 2606 OID 57872)
-- Name: users users_id_customer_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_id_customer_key UNIQUE (id_customer);


--
-- TOC entry 4823 (class 2606 OID 57874)
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id_user);


--
-- TOC entry 4825 (class 2606 OID 57876)
-- Name: users users_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_username_key UNIQUE (username);


--
-- TOC entry 4803 (class 1259 OID 57877)
-- Name: idx_customer_user; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_customer_user ON public.customer USING btree (id_user);


--
-- TOC entry 4814 (class 1259 OID 57878)
-- Name: idx_orders_customer; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_orders_customer ON public.orders USING btree (id_customer);


--
-- TOC entry 4815 (class 1259 OID 57879)
-- Name: idx_orders_date; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX idx_orders_date ON public.orders USING btree (order_date);


--
-- TOC entry 4828 (class 2606 OID 57880)
-- Name: customer customer_id_desa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_desa_fkey FOREIGN KEY (id_desa) REFERENCES public.desa_kelurahan(id_desa);


--
-- TOC entry 4829 (class 2606 OID 65828)
-- Name: customer customer_id_kabupaten_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_kabupaten_fkey FOREIGN KEY (id_kabupaten) REFERENCES public.kabupaten(id_kabupaten);


--
-- TOC entry 4830 (class 2606 OID 57957)
-- Name: customer customer_id_kecamatan_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_kecamatan_fkey FOREIGN KEY (id_kecamatan) REFERENCES public.kecamatan(id_kecamatan);


--
-- TOC entry 4831 (class 2606 OID 57895)
-- Name: customer customer_id_provinsi_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_provinsi_fkey FOREIGN KEY (id_provinsi) REFERENCES public.provinsi(id_provinsi);


--
-- TOC entry 4832 (class 2606 OID 57900)
-- Name: customer customer_id_user_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_id_user_fkey FOREIGN KEY (id_user) REFERENCES public.users(id_user);


--
-- TOC entry 4833 (class 2606 OID 57962)
-- Name: desa_kelurahan desa_kelurahan_id_kecamatan_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.desa_kelurahan
    ADD CONSTRAINT desa_kelurahan_id_kecamatan_fkey FOREIGN KEY (id_kecamatan) REFERENCES public.kecamatan(id_kecamatan);


--
-- TOC entry 4836 (class 2606 OID 65815)
-- Name: orders fk_customer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT fk_customer FOREIGN KEY (id_customer) REFERENCES public.customer(id_customer);


--
-- TOC entry 4839 (class 2606 OID 57920)
-- Name: users fk_user_customer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT fk_user_customer FOREIGN KEY (id_customer) REFERENCES public.customer(id_customer);


--
-- TOC entry 4834 (class 2606 OID 65842)
-- Name: kabupaten kabupaten_id_provinsi_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kabupaten
    ADD CONSTRAINT kabupaten_id_provinsi_fkey FOREIGN KEY (id_provinsi) REFERENCES public.provinsi(id_provinsi);


--
-- TOC entry 4835 (class 2606 OID 65833)
-- Name: kecamatan kecamatan_id_kabupaten_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kecamatan
    ADD CONSTRAINT kecamatan_id_kabupaten_fkey FOREIGN KEY (id_kabupaten) REFERENCES public.kabupaten(id_kabupaten);


--
-- TOC entry 4837 (class 2606 OID 57935)
-- Name: orders orders_id_customer_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_id_customer_fkey FOREIGN KEY (id_customer) REFERENCES public.customer(id_customer);


--
-- TOC entry 4838 (class 2606 OID 65810)
-- Name: orders orders_id_material_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_id_material_fkey FOREIGN KEY (id_material) REFERENCES public.materials(id_material) NOT VALID;


-- Completed on 2025-06-15 11:54:10

--
-- PostgreSQL database dump complete
--

